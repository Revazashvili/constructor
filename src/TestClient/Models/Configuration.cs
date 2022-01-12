namespace TestClient.Models
{
    public class Configuration
    {
        public DatabaseConfiguration Database { get; set; }
        public SchemaConfiguration Schema { get; set; }
        public TableConfiguration Table { get; set; }
        public ContextConfiguration Context { get; set; }
        public EntityConfiguration Entity { get; set; }
    }
}