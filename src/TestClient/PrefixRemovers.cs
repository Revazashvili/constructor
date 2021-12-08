using System.Linq;
using System.Text;

namespace TestClient
{
    public static class PrefixRemovers
    {
        public static string RemovePrefix(this string source, string prefix)
        {
            return source.StartsWith(prefix) ? source.Remove(0, prefix.Length) : source;
        }

        public static string RemovePrefixes(this string source, string[] prefixesToRemove)
        {
            var builder = new StringBuilder(source);
            builder = prefixesToRemove
                .Where(source.StartsWith)
                .Aggregate(builder, (current, prefix) => current.Remove(0, prefix.Length));

            return builder.ToString();
        }
    }
}