using System.Collections.Generic;

namespace TestClient.Models
{
    public class Table
    {
        public Table(IEnumerable<Column> columns)
        {
            Columns = columns;
        }

        public IEnumerable<Column> Columns { get; set; }
    }

    public class Column
    {
        public int ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public int Presicion { get; set; }
        public int Scale { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsRequired { get; set; }
        public int Length { get; set; }
    }
}