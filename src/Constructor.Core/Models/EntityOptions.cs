using System.Collections.Generic;

namespace Constructor.Core.Models
{
    public class EntityOptions
    {
        public EntityOptions()
        {
            Properties = new List<PropertyOptions>();
            OneToOneRelationships = new List<OneToOneRelationship>();
        }

        public string Name { get; set; }
        public string TableOrViewName { get; set; }
        public string Namespace { get; set; }
        public string SchemaName { get; set; }
        public bool IsTable { get; set; }
        public ICollection<PropertyOptions> Properties { get; set; }
        public ICollection<OneToOneRelationship> OneToOneRelationships { get; set; }
    }
}