using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStringFile
{
    internal class FileManager : IFileManager
    {
        public string selectFile()
        {
            var result = string.Empty;
            try
            {
                var selectFile = new System.Windows.Forms.OpenFileDialog();
                selectFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                selectFile.FilterIndex = 1;
                selectFile.Multiselect = false;
                if (selectFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    result = selectFile.FileName;
                    return result;
                }
                else
                {
                    throw new Exception("No file selected");
                }
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
                var lines = System.IO.File.ReadAllLines(path);
                return lines;
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
                var lines = System.IO.File.ReadAllLines(path);
                var result = lines.Where(x => x.Contains(filter)).ToArray();
                return result;
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
                var lineFile = new Dictionary<int, string>();
                var lines = System.IO.File.ReadAllLines(file);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(filter))
                    {
                        lineFile.Add(i + 1, lines[i]);
                    }
                }
                return lineFile;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
