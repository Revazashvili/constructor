namespace Constructor.App.Models
{
    public class DatabaseConfiguration
    {
        public DatabaseConfiguration() { }
        public DatabaseConfiguration(string provider, string connectionString)
        {
            Provider = provider;
            ConnectionString = connectionString;
        }

        public string Provider { get; set; }
        public string ConnectionString { get; set; }
    }
}