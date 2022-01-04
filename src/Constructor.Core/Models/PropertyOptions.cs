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

        public string Name { get; }
        public string ColumnName { get; }
        public string Type { get; }
        public bool IsPrimaryKey { get; }
        public bool IsRequired { get; }
        public int MaxLength { get; }
        public int Precision { get; }
        public int Scale { get; }
        public bool IsUnicode { get; }
    }
}