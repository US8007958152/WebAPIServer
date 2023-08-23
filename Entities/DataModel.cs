using Newtonsoft.Json;

namespace WebAPIServer.Entities
{
    public class DataModel
    {
        public string PackagePath { get; set; }
        public int Id { get; set; }
        public Variable[] Variables { get; set; }
        public View[] Views { get; set; }
        public Capability Capabilities { get; set; }
    }

    public class Variable
    {
        public string Type { get; set; }
        public Value[] Values { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultivalued { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Min { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Max { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsEnumerated { get; set; }
        public string VariableUsage { get; set; }
        public string HasPredefinedDomain { get; set; }
        public Property[] Properties { get; set; }
        
    }
    public class Value
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Property
    {
        public string Id { get; set; }
        public object Value { get; set; }
        public string Type { get; set; }
    }

    public class View
    {
        public string Id { get; set; }
        public bool Default { get; set; }
    }
    public class Capability
    {
        public bool Configuration { get; set; }
        public bool SolutionSpace { get; set; }
        public bool Conflicts { get; set; }
        public bool Explain { get; set; }
    }
}
