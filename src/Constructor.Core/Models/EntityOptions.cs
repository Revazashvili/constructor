using System.Collections.Generic;

namespace Constructor.Core.Models
{
    public class EntityOptions
    {
        public EntityOptions()
        {
            Properties = new List<PropertyOptions>();
            OneEntities = new List<string>();
            CollectionEntities = new List<string>();
            OneToOneRelationships = new List<OneToOneRelationship>();
            OneToManyRelationships = new List<OneToManyRelationship>();
            ManyToManyRelationships = new List<ManyToManyRelationships>();
        }

        public string Name { get; set; }
        public string TableOrViewName { get; set; }
        public string Namespace { get; set; }
        public string SchemaName { get; set; }
        public bool IsTable { get; set; }
        public ICollection<PropertyOptions> Properties { get; set; }
        public IEnumerable<string> OneEntities { get; set; }
        public IEnumerable<string> CollectionEntities { get; set; }
        public IEnumerable<OneToOneRelationship> OneToOneRelationships { get; set; }
        public IEnumerable<OneToManyRelationship> OneToManyRelationships { get; set; }
        public IEnumerable<ManyToManyRelationships> ManyToManyRelationships { get; set; }
    }
}