using Constructor.App.Options;

namespace Constructor.App.Handlers
{
    public static class ParsedHandler
    {
        public static void Handle(object obj)
        {
            switch (obj)
            {
                case ScaffoldOptions c:
                    ScaffoldHandler.Handle(c);
                    break;
            }
        }
    }
}