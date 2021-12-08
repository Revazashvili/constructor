using Constructor.Core.Models;
using Constructor.Core.Templates;

namespace Constructor.Core.Constructors
{
    public class ContextConstructor : IContextConstructor
    {
        public string Constructor(ContextOptions contextOptions)
        {
            var context = new Context {ContextOptions = contextOptions};
            return context.TransformText();
        }
    }
}