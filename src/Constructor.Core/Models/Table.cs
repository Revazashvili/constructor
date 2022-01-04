using System.Collections.Generic;

namespace Constructor.Core.Models
{
    public class Table
    {
        public Table(IEnumerable<Column> columns)
        {
            Columns = columns;
        }

        public IEnumerable<Column> Columns { get; }
    }
}