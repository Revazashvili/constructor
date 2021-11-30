using Constructor.Core.Models;

namespace Constructor.Core.Providers
{
    public interface IEntityOptionsProvider
    {
        EntityOptions Provide();
    }
}