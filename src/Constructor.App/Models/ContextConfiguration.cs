namespace Constructor.App.Models
{
    public class ContextConfiguration
    {
        public ContextConfiguration() { }

        public ContextConfiguration(string ns)
        {
            Namespace = ns;
        }

        public string Namespace { get; set; }
    }
}