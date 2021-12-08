using System.Text;

namespace TestClient
{
    public static class SuffixRemovers
    {
        public static string RemoveSuffix(this string source, string suffix)
        {
            return source.EndsWith(suffix) ? source[..^suffix.Length] : source;
        }

        public static string RemoveSuffixes(this string source, string[] suffixesToRemove)
        {
            var builder = new StringBuilder(source);
            foreach (var suffix in suffixesToRemove)
                if (source.EndsWith(suffix))
                    builder = builder.Remove(source.Length - suffix.Length, suffix.Length);

            return builder.ToString();
        }
    }
}