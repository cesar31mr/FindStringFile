using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStringFile
{
    internal class FileEntity
    {
        public int lineResult { get; set; }
        public string fileName { get; set; }
        public string fileDirectory { get; set; }

        public FileEntity(int lineResult, string fileName, string fileDirectory)
        {
            this.fileDirectory = fileDirectory;
            this.fileName = fileName;
            this.lineResult = lineResult;
        }

        public FileEntity()
        {
            
        }

        public override string ToString()
        {
            return string.Format("{0}\\{2}: [{1}] ", fileDirectory, lineResult, fileName);
        }
    }
}
