using System.Collections.Generic;
using TestClient.Models;

namespace TestClient
{
    public interface IDatabaseRepository
    {
        IEnumerable<string> GetTableNames();
        Table GetTableInfo(string tableName);
    }
}