namespace Constructor.Core.Models
{
    public class Column
    {
        public int ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public int? Precision { get; set; }
        public int? Scale { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsRequired { get; set; }
        public int Length { get; set; }
        public bool IsUnicode { get; set; }
    }
}