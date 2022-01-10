using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Core.Managers;
using Constructor.Core.Models;
using Constructor.Core.Repositories;
using Dapper;
using Microsoft.VisualBasic;

namespace Constructor.Infrastructure.Repositories
{
    public class OracleRepository : IDatabaseRepository
    {
        private readonly IConnectionManager _connectionManager;

        public OracleRepository(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public async Task<IEnumerable<string>> GetSchemas()
        {
            var connection = _connectionManager.OpenConnection();
            const string sql = "select username as schema from sys.all_users order by username ";
            var schemas = await connection.QueryAsync<string>(sql);
            return schemas;
        }

        public async Task<IEnumerable<string>> GetTables(string schema)
        {
            var connection = _connectionManager.OpenConnection();
            const string sql = "select t.TABLE_NAME from SYS.ALL_TABLES t where t.OWNER=:schema order by t.TABLE_NAME ";
            var result = await connection.QueryAsync<string>(sql, new { schema });
            _connectionManager.CloseConnection(connection);
            return result;
        }

        public async Task<IEnumerable<string>> GetViews(string schema)
        {
            var connection = _connectionManager.OpenConnection();
            const string sql = "select v.VIEW_NAME from SYS.ALL_VIEWS v where v.OWNER=:schema order by v.VIEW_NAME ";
            var result = await connection.QueryAsync<string>(sql, new { schema });
            _connectionManager.CloseConnection(connection);
            return result;
        }

        public Table GetTableInfo(string tableName)
        {
            var connection = _connectionManager.OpenConnection();
            const string sql =
                @"select t.COLUMN_NAME ColumnName,t.COLUMN_ID ColumnId,t.DATA_TYPE DataType,t.DATA_PRECISION Precision,t.DATA_SCALE Scale,
                    case t.NULLABLE when 'Y' then 0 else 1 end IsRequired,t.CHAR_LENGTH Length,
                    case when exists (SELECT cols.column_name
                    FROM all_constraints cons NATURAL JOIN all_cons_columns cols
                    WHERE cons.constraint_type = 'P' and cols.COLUMN_NAME=t.COLUMN_NAME AND table_name = UPPER(:tableName )) then 1 else 0 end IsPrimaryKey,
                    0 as IsUnicode
                     from user_tab_columns t where t.TABLE_NAME=:tableName ";
            var columns = connection.Query<Column>(sql, new { tableName }).AsEnumerable();
            _connectionManager.CloseConnection(connection);
            return new Table(columns);
        }
    }
}