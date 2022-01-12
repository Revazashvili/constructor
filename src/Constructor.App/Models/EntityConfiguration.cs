namespace Constructor.App.Models
{
    public class EntityConfiguration
    {
        public EntityConfiguration() { }

        public EntityConfiguration(string ns)
        {
            Namespace = ns;
        }

        public string Namespace { get; set; }
    }
}