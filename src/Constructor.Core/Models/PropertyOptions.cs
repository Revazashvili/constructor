namespace Constructor.Core.Models
{
    public class PropertyOptions
    {
        public string Name { get; set; }
        public string ColumnName { get; set; }
        public string Type { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsRequired { get; set; }
        public int MaxLength { get; set; }
    }
}