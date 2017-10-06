using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace scripts
{
    class Program
    {
        static void Main(string[] args)
        {
            var errors = File.ReadAllLines("./errors");
            var regex = new Regex("/([^\\(/]+)\\(\\d+,\\d+\\): error ([^:]+): '([^']+)' .+ '(\\w+\\.\\w+).+");
            var classes = new Dictionary<string, List<string>>();
            var metadata = new List<string>();

            for (int i = 0; i < errors.Length; i++)
            {
                var match = regex.Match(errors[i]);
                var items = match.Groups.Skip(1).Select(x => x.Value).ToList();

                if (items.Count < 2 || items[1] != "CS0534") continue;

                var classFile = items[0].Substring(0, items[0].LastIndexOf('.'));
                var ns = classFile.Substring(0, classFile.LastIndexOf('.'));
                var name = classFile.Substring(classFile.LastIndexOf('.') + 1);
                var jname = items[2];
                var baseCls = items[3];

                List<string> cls;
                if (!classes.ContainsKey(ns)) {
                    cls = new List<string>();
                    classes[ns] = cls;
                } else {
                    cls = classes[ns];
                }

                Console.WriteLine($"{i}:{classFile}");

                switch (baseCls)
                {
                    case "StoneSerializer.Deserialize":
                        cls.Add($@"
partial class {name} {{
    partial class Serializer
    {{
        public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
        {{
            return Deserialize{name}(parser);
        }}

        public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
        {{
            Serialize(({name})value, generator);
        }}
    }}
}}                      
");
                        metadata.Add($@"
<attr
    path=""/api/package[@name='{ns.ToLower()}']/class[@name='{name}.Serializer']/method[@name='deserialize' and count(parameter)=1 and parameter[1][@type='com.fasterxml.jackson.core.JsonParser']]""
    name=""managedName"">Deserialize{name}</attr>
");

                        break;
                    case "StructSerializer.Deserialize":
                        cls.Add($@"
partial class {name} {{
    partial class Serializer
    {{
        public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
        {{
            return Deserialize{name}(parser, collapsed);
        }}

        public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
        {{
            Serialize(({name})value, generator, collapse);
        }}
    }}
}}                      
");
                        metadata.Add($@"
<attr
    path=""/api/package[@name='{ns.ToLower()}']/class[@name='{name}.Serializer']/method[@name='deserialize' and count(parameter)=2 and parameter[1][@type='com.fasterxml.jackson.core.JsonParser'] and parameter[2][@type='boolean']]""
    name=""managedName"">Deserialize{name}</attr>
");

                        break;
                    default:
                        break;
                }
            }

            File.WriteAllText("./metadata.xml", string.Join("\n", metadata));
            Console.WriteLine("Done metadata");

            File.WriteAllText("./classes.cs", string.Join("\n", classes.Select(x => $@"
namespace {x.Key} {{
    {string.Join("\n", x.Value)}
}}
")));
            Console.WriteLine("Done classes");
            Console.ReadLine();
        }
    }
}
