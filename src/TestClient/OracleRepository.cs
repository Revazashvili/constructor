using System.Collections.Generic;
using System.Linq;
using Dapper;
using TestClient.Models;

namespace TestClient
{
    public class OracleRepository : IDatabaseRepository
    {
        private readonly IConnectionManager _connectionManager;

        public OracleRepository(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public IEnumerable<string> GetTableNames()
        {
            var connection = _connectionManager.OpenConnection();
            const string sql = "select t.TABLE_NAME from user_tables t";
            var result = connection.Query<string>(sql).AsEnumerable();
            _connectionManager.CloseConnection(connection);
            return result;
        }

        public Table GetTableInfo(string tableName)
        {
            var connection = _connectionManager.OpenConnection();
            const string sql =
                @"select t.COLUMN_NAME ColumnName,t.COLUMN_ID ColumnId,t.DATA_TYPE DataType,t.DATA_PRECISION Precision,t.DATA_SCALE Scale,case t.NULLABLE when 'Y' then 0 else 1 end IsRequired,t.CHAR_LENGTH Length,
                    case when exists (SELECT cols.column_name
                    FROM all_constraints cons NATURAL JOIN all_cons_columns cols
                    WHERE cons.constraint_type = 'P' and cols.COLUMN_NAME=t.COLUMN_NAME AND table_name = UPPER(:table_name )) then 1 else 0 end IsPrimary
                     from user_tab_columns t where t.TABLE_NAME=:table_name ";
            var columns = connection.Query<Column>(sql, new {table_name = tableName}).AsEnumerable();
            _connectionManager.CloseConnection(connection);
            return new Table(columns);
        }
    }
}