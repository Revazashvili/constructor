namespace Constructor.Core.Models
{
    public class PropertyOptions
    {
        public PropertyOptions(string name, string columnName, string type, bool isPrimaryKey, bool isRequired,
            int maxLength, int precision, int scale, bool isUnicode)
        {
            Name = name;
            ColumnName = columnName;
            Type = type;
            IsPrimaryKey = isPrimaryKey;
            IsRequired = isRequired;
            MaxLength = maxLength;
            Precision = precision;
            Scale = scale;
            IsUnicode = isUnicode;
        }

        public string Name { get; set; }
        public string ColumnName { get; set; }
        public string Type { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsRequired { get; set; }
        public int MaxLength { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }
        public bool IsUnicode { get; set; }
    }
}