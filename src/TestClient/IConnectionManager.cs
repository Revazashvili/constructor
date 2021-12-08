using System.Data;

namespace TestClient
{
    public interface IConnectionManager
    {
        IDbConnection OpenConnection();
        void CloseConnection(IDbConnection connection);
    }
}