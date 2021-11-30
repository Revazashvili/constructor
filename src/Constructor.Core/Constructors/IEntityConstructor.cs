using Constructor.Core.Models;

namespace Constructor.Core.Constructors
{
    public interface IEntityConstructor
    {
        string Construct(EntityOptions entityOptions);
    }
}