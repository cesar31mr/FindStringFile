namespace FindStringFile
{
    internal interface IDirectoryManager
    {
        string[] getDirectories(string path);
        string[] readFiles(string path);
        string selectDirectory();
    }
}