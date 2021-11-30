using System.IO;

namespace Constructor.Core.Managers
{
    public class FileManager : IFileManager
    {
        public void Save(string filePath, string fileContent)
        {
            var file = new FileInfo(filePath);
            file.Directory?.Create();
            File.WriteAllText(filePath, fileContent);
        }
    }
}