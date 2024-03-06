using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStringFile
{
    internal class DirectoryManager : IDirectoryManager
    {
        public string selectDirectory()
        {
            var result = string.Empty;
            try
            {
                var selectDirectory = new System.Windows.Forms.FolderBrowserDialog();
                if (selectDirectory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    result = selectDirectory.SelectedPath;
                    return result;
                }
                else
                {
                    throw new Exception("No directory selected");
                }
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
                var directories = System.IO.Directory.GetDirectories(path);
                return directories;
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
                var files = System.IO.Directory.GetFiles(path);
                return files;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
