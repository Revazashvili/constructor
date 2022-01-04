using System.Data;

namespace Constructor.Core.Managers
{
    public interface IConnectionManager
    {
        IDbConnection OpenConnection();
        void CloseConnection(IDbConnection connection);
    }
}