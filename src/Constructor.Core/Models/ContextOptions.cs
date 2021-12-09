using System.Collections.Generic;

namespace Constructor.Core.Models
{
    public class ContextOptions
    {
        public string Namespace { get; set; }
        public string Name { get; set; }
        public string EntitiesNamespace { get; set; }
        public IEnumerable<string> Entities { get; set; }
    }
}