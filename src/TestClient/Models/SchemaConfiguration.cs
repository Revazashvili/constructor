using System.Collections.Generic;

namespace TestClient.Models
{
    public class SchemaConfiguration
    {
        public SchemaConfiguration() { }

        public SchemaConfiguration(bool scaffoldAll, IEnumerable<string> schemas)
        {
            ScaffoldAll = scaffoldAll;
            Schemas = schemas;
        }

        public bool ScaffoldAll { get; set; }
        public IEnumerable<string> Schemas { get; set; }
    }
}