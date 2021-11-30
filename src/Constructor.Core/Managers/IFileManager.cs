namespace Constructor.Core.Managers
{
    public interface IFileManager
    {
        void Save(string filePath, string fileContent);
    }
}