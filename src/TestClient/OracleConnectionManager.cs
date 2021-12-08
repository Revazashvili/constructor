using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace TestClient
{
    public class OracleConnectionManager : IConnectionManager
    {
        private readonly string _connectionString;

        public OracleConnectionManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection OpenConnection()
        {
            var connection = new OracleConnection(_connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public void CloseConnection(IDbConnection connection)
        {
            if (connection.State is ConnectionState.Open or ConnectionState.Broken)
                connection.Close();
        }
    }
}