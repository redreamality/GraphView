﻿// GraphView
// 
// Copyright (c) 2015 Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace GraphView
{
    internal class WSqlTableContext
    {
        public WSqlTableContext UpperLevel { get; set; }

        private readonly Dictionary<MatchEdge, ColumnStatistics> _edgeStatisticses =
            new Dictionary<MatchEdge, ColumnStatistics>();

        private readonly Dictionary<string, WTableReferenceWithAlias> _nodeTableDictionary =
            new Dictionary<string, WTableReferenceWithAlias>(StringComparer.CurrentCultureIgnoreCase);

        private readonly Dictionary<string, Tuple<WSchemaObjectName, WEdgeColumnReferenceExpression>> _edgeDictionary =
            new Dictionary<string, Tuple<WSchemaObjectName, WEdgeColumnReferenceExpression>>(StringComparer.CurrentCultureIgnoreCase);

        private Dictionary<string, string> _columnTableAliasMapping;

        public Dictionary<string, WTableReferenceWithAlias> NodeTableDictionary
        {
            get { return _nodeTableDictionary; }
        }

        public Dictionary<string, Tuple<WSchemaObjectName, WEdgeColumnReferenceExpression>> EdgeDictionary
        {
            get { return _edgeDictionary; }
        }

        public ColumnStatistics GetEdgeStatistics(MatchEdge edge)
        {
            return _edgeStatisticses[edge];
        }

        public WTableReferenceWithAlias this[string name]
        {
            get
            {
                var currentContext = this;
                while (currentContext != null)
                {
                    WTableReferenceWithAlias value;
                    if (currentContext.NodeTableDictionary.TryGetValue(name, out value))
                        return value;
                    currentContext = currentContext.UpperLevel;
                }
                return null;
            }
        }

        public bool CheckTable(string name)
        {
            return this[name] != null;
        }

        public Dictionary<string, string> GetColumnTableMapping(
            Dictionary<Tuple<string, string>, Dictionary<string, NodeColumns>> columnsOfNodeTables)
        {
            if (_columnTableAliasMapping == null)
            {
                _columnTableAliasMapping = new Dictionary<string, string>(StringComparer.CurrentCultureIgnoreCase);
                var duplicateColumns = new HashSet<string>();
                foreach (var kvp in NodeTableDictionary)
                {
                    var nodeTable = kvp.Value as WNamedTableReference;
                    if (nodeTable != null)
                    {
                        var nodeTableObjectName = nodeTable.TableObjectName;
                        var nodeTableTuple = WNamedTableReference.SchemaNameToTuple(nodeTableObjectName);
                        foreach (
                            var property in
                                columnsOfNodeTables[nodeTableTuple].Where(e => e.Value.Role != WNodeTableColumnRole.Edge)
                                    .Select(e => e.Key))
                        {
                            if (!_columnTableAliasMapping.ContainsKey(property.ToLower()))
                            {
                                _columnTableAliasMapping[property.ToLower()] = kvp.Key;
                            }
                            else
                            {
                                duplicateColumns.Add(property.ToLower());
                            }
                        }
                    }
                }

                foreach (var kvp in EdgeDictionary)
                {

                    var tuple = kvp.Value;
                    var sourceTableObjectName = tuple.Item1;
                    var edgeColumnReference = tuple.Item2;
                    var soureNodeTableTuple =
                        WNamedTableReference.SchemaNameToTuple(sourceTableObjectName);
                    var edgeProperties =
                        columnsOfNodeTables[soureNodeTableTuple][
                            edgeColumnReference.MultiPartIdentifier.Identifiers.Last().Value.ToLower()];
                    foreach (var attribute in edgeProperties.ColumnAttributes)
                    {
                        if (!_columnTableAliasMapping.ContainsKey(attribute.ToLower()))
                        {
                            _columnTableAliasMapping[attribute.ToLower()] = kvp.Key;
                        }
                        else
                        {
                            duplicateColumns.Add(attribute.ToLower());
                        }
                    }


                }
                foreach (var col in duplicateColumns)
                    _columnTableAliasMapping.Remove(col);
            }
            return _columnTableAliasMapping;
        }

        public Dictionary<string, WTableReferenceWithAlias> GetUpperTableDictionary()
        {
            var currentContext = UpperLevel;
            var upperTableDictionary =
                new Dictionary<string, WTableReferenceWithAlias>(StringComparer.CurrentCultureIgnoreCase);
            while (currentContext != null)
            {
                foreach (var table in currentContext.NodeTableDictionary)
                    upperTableDictionary.Add(table.Key, table.Value);
                currentContext = currentContext.UpperLevel;
            }
            return upperTableDictionary;
        }

        public void AddNodeTable(string name, WTableReferenceWithAlias tableName)
        {
            if (_nodeTableDictionary.ContainsKey(name) || _edgeDictionary.ContainsKey(name))
                throw new GraphViewException("Duplicate Alias");
            _nodeTableDictionary.Add(name, tableName);
        }

        public void AddEdgeReference(string name, WSchemaObjectName sourceNodeName, WEdgeColumnReferenceExpression edgeReference)
        {
            if (_nodeTableDictionary.ContainsKey(name) || _edgeDictionary.ContainsKey(name))
                throw new GraphViewException("Duplicate Alias");
            _edgeDictionary.Add(name,
                new Tuple<WSchemaObjectName, WEdgeColumnReferenceExpression>(sourceNodeName, edgeReference));
        }

        public void AddEdgeStatistics(MatchEdge edge, ColumnStatistics statistics)
        {
            _edgeStatisticses.Add(edge, statistics);
        }
    }
}
