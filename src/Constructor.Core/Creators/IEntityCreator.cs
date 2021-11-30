using Constructor.Core.Models;

namespace Constructor.Core.Creators
{
    public interface IEntityCreator
    {
        void Create(CreateEntityOptions createEntityOptions);
    }
}