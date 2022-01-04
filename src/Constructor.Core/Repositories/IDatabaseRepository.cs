using System.Collections.Generic;
using Constructor.Core.Models;

namespace Constructor.Core.Repositories
{
    public interface IDatabaseRepository
    {
        IEnumerable<string> GetTableNames();
        Table GetTableInfo(string tableName);
    }
}