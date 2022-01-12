using System.Collections.Generic;

namespace Constructor.App.Models
{
    public class TableConfiguration
    {
        public TableConfiguration() { }

        public TableConfiguration(bool generateAll, IEnumerable<string> tables, string prefixToRemove, string suffixToRemove)
        {
            GenerateAll = generateAll;
            Tables = tables;
            PrefixToRemove = prefixToRemove;
            SuffixToRemove = suffixToRemove;
        }

        public bool GenerateAll { get; set; }
        public IEnumerable<string> Tables { get; set; }
        public string PrefixToRemove { get; set; }
        public string SuffixToRemove { get; set; }
    }
}