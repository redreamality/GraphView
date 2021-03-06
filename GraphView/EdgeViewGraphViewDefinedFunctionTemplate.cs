﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace GraphView
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class EdgeViewGraphViewDefinedFunctionTemplate : EdgeViewGraphViewDefinedFunctionTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("    ");
            this.Write("    ");
            this.Write("    ");
            this.Write("    ");
            this.Write("    ");
            this.Write("\r\n");
            
            #line 8 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

    var typeDictionary = new Dictionary<string, Tuple<string, string>> 
{ 
{"int", new Tuple<string, string>("int", "Int32")},
{"long", new Tuple<string, string>("bigint", "Int64")},
{"double", new Tuple<string, string>("float", "Double")},
{"string", new Tuple<string, string>("nvarchar(4000)", "String")}
    };
            
            #line default
            #line hidden
            this.Write(@"    using System;
    using System.IO;
    using System.Collections;
	using System.Collections.Generic;
    using System.Data.SqlTypes;
    using System.Text;
    using Microsoft.SqlServer.Server;

    public partial class UserDefinedFunctions
	{
    private class ");
            
            #line 26 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("DecoderResult\r\n    {\r\n\t\tpublic long Sink { get; set; }\r\n\t\tpublic Int32 EdgeId{ ge" +
                    "t; set; }\r\n");
            
            #line 30 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
foreach (var variable in AttributeTypeDict) {
            
            #line default
            #line hidden
            this.Write("\t\tpublic Sql");
            
            #line 31 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeDictionary[variable.Value].Item2));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 31 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(variable.Key));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 32 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t}\r\n\r\n    public static void ");
            
            #line 35 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("Decoder_FillRow(\r\n    object tableTypeObject,\r\n    out SqlInt64 sink, out SqlInt3" +
                    "2 edgeid");
            
            #line 37 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

    var indent = "        ";
    foreach (var variable in AttributeTypeDict) {
        WriteLine(",");
        Write(indent + "out Sql" + typeDictionary[variable.Value].Item2 + " " + variable.Key);
    }
            
            #line default
            #line hidden
            this.Write(")\r\n    {\r\n        var decoderResult = (");
            
            #line 44 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("DecoderResult)tableTypeObject;\r\n        sink = decoderResult.Sink;\r\n        edgei" +
                    "d = decoderResult.EdgeId;\r\n");
            
            #line 47 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
foreach (var variable in AttributeTypeDict) {
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 48 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(variable.Key));
            
            #line default
            #line hidden
            this.Write(" = decoderResult.");
            
            #line 48 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(variable.Key));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 49 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    [SqlFunction(\r\n    DataAccess = DataAccessKind.None,\r\n    TableDefin" +
                    "ition = \"Sink bigint, EdgeId int");
            
            #line 54 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

    foreach(var variable in AttributeTypeDict)
    Write(", " + variable.Key + " " + typeDictionary[variable.Value].Item1);

            
            #line default
            #line hidden
            this.Write("\",\r\n    FillRowMethodName = \"");
            
            #line 58 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("Decoder_FillRow\",\r\n    IsDeterministic = true,\r\n    IsPrecise = false\r\n    )]\r\n\r\n" +
                    "\tpublic static IEnumerable ");
            
            #line 63 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("Decoder(\r\n");
            
            #line 64 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

    if (Mapping.Count() != 0){
        Write(indent + "SqlBytes array0");
        WriteLine(",");
        Write(indent + "SqlBytes dele0");
    }
    for (int i = 1; i < Mapping.Count(); i++) {
        WriteLine(",");
        Write(indent + "SqlBytes array" + i.ToString());
        WriteLine(",");
        Write(indent + "SqlBytes dele" + i.ToString());
    }
            
            #line default
            #line hidden
            this.Write(")\r\n    {\r\n        var edgeid = (Int32)0;\r\n\t\tvar deleDict = new Dictionary<Int32, " +
                    "bool>();\r\n");
            
            #line 79 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

    var calc = 0;
	indent += "    ";
    foreach(var it in Mapping) {
        var array = "array" + calc.ToString();
		var dele = "dele" + calc.ToString();
        calc++;
        var variables = it.Value;
        var attributeSize = variables.Count();
        var byteSize = (attributeSize - 1) / 8 + 1; 
        if (attributeSize == 0) {
            byteSize = 0;
        }

            
            #line default
            #line hidden
            this.Write("\t\tedgeid = 0;\r\n\t\tdeleDict.Clear();\r\n\t\tif (");
            
            #line 95 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dele));
            
            #line default
            #line hidden
            this.Write(" != null && !");
            
            #line 95 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dele));
            
            #line default
            #line hidden
            this.Write(".IsNull) \r\n\t\t{\r\n\t\t\tvar brdele = new BinaryReader(new MemoryStream(");
            
            #line 97 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dele));
            
            #line default
            #line hidden
            this.Write(".Value));\r\n\t\t\twhile (brdele.BaseStream.Position != brdele.BaseStream.Length)\r\n\t\t\t" +
                    "{\r\n\t\t\t\tdeleDict[brdele.ReadInt32()] = true;\r\n\t\t\t}\r\n\t\t}\r\n\t\tif (");
            
            #line 103 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(array));
            
            #line default
            #line hidden
            this.Write(" != null && !");
            
            #line 103 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(array));
            
            #line default
            #line hidden
            this.Write(".IsNull)\r\n\t\t{\r\n        var br = new BinaryReader(new MemoryStream(");
            
            #line 105 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(array));
            
            #line default
            #line hidden
            this.Write(".Value));\r\n        while (br.BaseStream.Position != br.BaseStream.Length)\r\n      " +
                    "  {\r\n            edgeid++;\r\n");
            
            #line 109 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
if (byteSize != 0) {
            
            #line default
            #line hidden
            this.Write("            byte[] bitmap = br.ReadBytes(");
            
            #line 110 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(byteSize));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 111 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("            var sink = br.ReadInt64();\r\n            object temp;\r\n");
            
            #line 114 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

            var count = 0;
            foreach (var iterator in AttributeTypeDict) {
                    WriteLine(indent + "var _" + iterator.Key + " = Sql" + typeDictionary[iterator.Value].Item2 + ".Null;"); }
            foreach (var variable in variables)
            {
                    var variableName = (variable.Item2 == "") ? "temp": "_" + variable.Item2;
                    var variableType = variable.Item1;
                    var str = "((bitmap["+ (count / 8).ToString() + "]" + " & " + (1 << (count%8)).ToString() + ") == 0)? Sql" + typeDictionary[variableType].Item2 + ".Null" +" :";
                    if (attributeSize == 0) {
                        str = "";
                    }
                    WriteLine(indent + variableName + " = " + str + "br.Read" + typeDictionary[variableType].Item2 + "();");
                    count++;
            }

            
            #line default
            #line hidden
            this.Write("\t\t\tif (!deleDict.ContainsKey(edgeid)) {\r\n\t\t\t\tyield return new ");
            
            #line 131 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("DecoderResult\r\n\t\t\t\t{\r\n\t\t\t\t\tSink = sink, EdgeId = edgeid,\r\n");
            
            #line 134 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

					foreach (var variable in AttributeTypeDict)
					{
						WriteLine(indent + "    " + variable.Key + " = _" + variable.Key + ",");
					}

            
            #line default
            #line hidden
            this.Write("\t\t\t\t};\r\n\t\t\t}\r\n        }\r\n\t\t}\r\n");
            
            #line 144 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\tyield break;\r\n    }\r\n\r\n\r\n   //Path Decoder\r\n    private class ");
            
            #line 150 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("PathDecoderResult \r\n    {\r\n        public int EdgeId{get; set;}\r\n        public l" +
                    "ong SinkId{get; set;}\r\n");
            
            #line 154 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
foreach (var variable in AttributeTypeDict) {
            
            #line default
            #line hidden
            this.Write("        public Sql");
            
            #line 155 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeDictionary[variable.Value].Item2));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 155 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(variable.Key));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 156 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    public static void ");
            
            #line 159 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("PathDecoder_FillRow(\r\n        object tableTypeObject,\r\n        out SqlInt32 EdgeI" +
                    "d, out SqlInt64 SinkId ");
            
            #line 161 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"


		foreach (var variable in AttributeTypeDict) {
            WriteLine(",");
            Write(indent + "out Sql" + typeDictionary[variable.Value].Item2 + " " + variable.Key);
		}
            
            #line default
            #line hidden
            this.Write("        )\r\n    {\r\n        var decoderResult = (");
            
            #line 169 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("PathDecoderResult)tableTypeObject;\r\n        EdgeId = decoderResult.EdgeId;\r\n     " +
                    "   SinkId = decoderResult.SinkId;\r\n");
            
            #line 172 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
foreach (var variable in  AttributeTypeDict) {
            
            #line default
            #line hidden
            this.Write("      ");
            
            #line 173 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(variable.Key));
            
            #line default
            #line hidden
            this.Write(" = decoderResult.");
            
            #line 173 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(variable.Key));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 174 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("    }\r\n    \r\n        [SqlFunction(\r\n        DataAccess = DataAccessKind.None,\r\n  " +
                    "      TableDefinition = \"EdgeId int, SinkId bigint\",\r\n        FillRowMethodName " +
                    "= \"");
            
            #line 180 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("PathDecoder_FillRow\",\r\n        IsDeterministic = true,\r\n        IsPrecise = false" +
                    "\r\n        )]\r\n    public static IEnumerable ");
            
            #line 184 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("PathDecoder(\r\n\t\tSqlBytes  PathVarbinary,\r\n\t\tSqlInt64 nodeid,\r\n");
            
            #line 187 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

	indent = "        ";
    if (Mapping.Count() != 0){
        Write(indent + "SqlBytes array0");
        WriteLine(",");
        Write(indent + "SqlBytes dele0");
    }
    for (int i = 1; i < Mapping.Count(); i++) {
        WriteLine(",");
        Write(indent + "SqlBytes array" + i.ToString());
        WriteLine(",");
        Write(indent + "SqlBytes dele" + i.ToString());
}
            
            #line default
            #line hidden
            this.Write(@")
    {
        var PathMemory = (PathVarbinary != null && !PathVarbinary.IsNull) ? new MemoryStream(PathVarbinary.Value) : new MemoryStream();
        var brPath = new BinaryReader(PathMemory);
        var PathDict =  new Dictionary<Tuple<long, Int32>, bool>();
        if (PathVarbinary != null && !PathVarbinary.IsNull) {
            while (brPath.BaseStream.Position != brPath.BaseStream.Length)
            {
                var Edgeid = Tuple.Create(brPath.ReadInt64(), brPath.ReadInt32());
                PathDict[Edgeid] = true;
            }
        }
        
        foreach (var it in ");
            
            #line 212 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("Decoder(\r\n");
            
            #line 213 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

	indent += "    ";
    if (Mapping.Count() != 0){
        Write(indent + "array0");
        WriteLine(",");
        Write(indent + "dele0");
    }
    for (int i = 1; i < Mapping.Count(); i++) {
        WriteLine(",");
        Write(indent + "array" + i.ToString());
        WriteLine(",");
        Write(indent + "dele" + i.ToString());
}
            
            #line default
            #line hidden
            this.Write("))\r\n        {\r\n            var  adjacent = it as ");
            
            #line 227 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("DecoderResult;\r\n            var EdgeId = Tuple.Create(nodeid.Value, adjacent.Edge" +
                    "Id);\r\n            if (!PathDict.ContainsKey(EdgeId))\r\n            {\r\n           " +
                    "     yield return new ");
            
            #line 231 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EdgeName));
            
            #line default
            #line hidden
            this.Write("PathDecoderResult\r\n                {\r\n                    EdgeId = adjacent.EdgeI" +
                    "d,\r\n                    SinkId = adjacent.Sink,\r\n");
            
            #line 235 "C:\Users\v-junry.FAREAST\Source\Repos\GraphView\GraphView\EdgeViewGraphViewDefinedFunctionTemplate.tt"

					indent += "        ";
					foreach (var variable in AttributeTypeDict) {
                        WriteLine(indent + variable.Key + " = adjacent." + variable.Key + ",");
					}

            
            #line default
            #line hidden
            this.Write("                };\r\n            }\r\n        }\r\n        yield break;\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class EdgeViewGraphViewDefinedFunctionTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
