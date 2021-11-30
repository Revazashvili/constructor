using Constructor.Core.Models;
using Constructor.Core.Templates;

namespace Constructor.Core.Constructors
{
    public class EntityConfigurationConstructor : IEntityConfigurationConstructor
    {
        public string Construct(EntityOptions entityOptions)
        {
            var entityConfiguration = new EntityConfiguration { EntityOptions = entityOptions };
            return entityConfiguration.TransformText();
        }
    }
}