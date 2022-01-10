using System.Collections.Generic;

namespace Constructor.Core.Models
{
    public class Table
    {
        public Table(IEnumerable<Column> columns)
        {
            Columns = columns;
        }

        public string Name { get; set; }
        public string Schema { get; set; }
        public IEnumerable<Column> Columns { get; }
    }
}