using Constructor.Core.Creators.Options;
using Constructor.Core.Models;

namespace Constructor.Core.Creators
{
    public interface IContextCreator
    {
        void Create(CreateContextOptions createContextOptions);
    }
}