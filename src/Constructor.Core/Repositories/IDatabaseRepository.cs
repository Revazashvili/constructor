using System.Collections.Generic;
using System.Threading.Tasks;
using Constructor.Core.Models;

namespace Constructor.Core.Repositories
{
    public interface IDatabaseRepository
    {
        Task<IEnumerable<string>> GetSchemas();
        Task<IEnumerable<string>> GetTables(string schema);
        Task<IEnumerable<string>> GetViews(string schema);
        Table GetTableInfo(string tableName);
    }
}