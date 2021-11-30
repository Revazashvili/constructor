using Constructor.Core.Models;
using Constructor.Core.Templates;

namespace Constructor.Core.Constructors
{
    public class EntityConstructor : IEntityConstructor
    {
        public string Construct(EntityOptions entityOptions)
        {
            var entity = new Entity { EntityOptions = entityOptions };
            return entity.TransformText();
        }
    }
}