using Constructor.Core.Models;

namespace Constructor.Core.Constructors
{
    public interface IContextConstructor
    {
        string Constructor(ContextOptions contextOptions);
    }
}