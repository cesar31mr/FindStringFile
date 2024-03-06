using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStringFile
{
    internal class FindStringBusiness : IFindStringBusiness
    {
        private IFileManager _fileManager;
        private IDirectoryManager _directoryManager;

        public FindStringBusiness()
        {
            _fileManager = new FileManager();
            _directoryManager = new DirectoryManager();
        }

        public List<FileEntity> findFileWithFilter(string path, string filter)
        {
            try
            {
                var directories = _directoryManager.getDirectories(path);
                var result = new List<FileEntity>();

                directories.Append(path);

                foreach (var directory in directories)
                {
                    var filesInDirectory = _directoryManager.readFiles(directory);

                    foreach (var file in filesInDirectory)
                    {
                        var lines = _fileManager.readFileWithFilterAndLine(file, filter);
                        
                        foreach (var line in lines)
                        {
                            result.Add(new FileEntity(line.Key, file, directory));
                        }
                    }
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string[] readFile(string path)
        {
            try
            {
                return _fileManager.readFile(path);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string[] readFileWithFilter(string path, string filter)
        {
            try
            {
                return _fileManager.readFileWithFilter(path, filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dictionary<int, string> readFileWithFilterAndLine(string file, string filter)
        {
            try
            {
                return _fileManager.readFileWithFilterAndLine(file, filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string selectFile()
        {
            try
            {
                return _fileManager.selectFile();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string selectDirectory()
        {
            try
            {
                return _directoryManager.selectDirectory();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string[] getDirectories(string path)
        {
            try
            {
                return _directoryManager.getDirectories(path);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string[] readFiles(string path)
        {
            try
            {
                return _directoryManager.readFiles(path);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
