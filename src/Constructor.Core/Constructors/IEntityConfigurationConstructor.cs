using Constructor.Core.Models;

namespace Constructor.Core.Constructors
{
    public interface IEntityConfigurationConstructor
    {
        string Construct(EntityOptions entityOptions);
    }
}