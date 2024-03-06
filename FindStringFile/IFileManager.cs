
namespace FindStringFile
{
    internal interface IFileManager
    {
        string[] readFile(string path);
        string[] readFileWithFilter(string path, string filter);
        Dictionary<int, string> readFileWithFilterAndLine(string file, string filter);
        string selectFile();
    }
}