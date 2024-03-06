
namespace FindStringFile
{
    internal interface IFindStringBusiness
    {
        List<FileEntity> findFileWithFilter(string path, string filter);
        string[] getDirectories(string path);
        string[] readFile(string path);
        string[] readFiles(string path);
        string[] readFileWithFilter(string path, string filter);
        Dictionary<int, string> readFileWithFilterAndLine(string file, string filter);
        string selectDirectory();
        string selectFile();
    }
}