using System.Collections.Generic;

namespace Constructor.Core.Models
{
    public class EntityOptions
    {
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Schema { get; set; }
        public ICollection<PropertyOptions> Properties { get; set; }
        public bool IsTable { get; set; }
    }
}