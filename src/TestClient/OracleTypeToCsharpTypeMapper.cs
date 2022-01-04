using System;

namespace TestClient
{
    public class OracleTypeToCsharpTypeMapper
    {
        public static string MapOracleTypeToCSharpType(string dataType)
        {
            return dataType switch
            {
                "DATE" => "DateTime",
                "VARCHAR" => "string",
                "VARCHAR2" => "string",
                _ => throw new ArgumentOutOfRangeException(nameof(dataType), dataType, null)
            };
        }
    }
}