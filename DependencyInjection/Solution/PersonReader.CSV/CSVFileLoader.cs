using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PersonReader.CSV
{
    public interface ICSVFileLoader
    {
        string LoadFile();
    }

    public class CSVFileLoader : ICSVFileLoader
    {
        private string filePath;

        public CSVFileLoader(string filePath)
        {
            this.filePath = filePath;
        }

        public string LoadFile()
        {
            using (var reader = new StreamReader(filePath))
            {
                string fileData = reader.ReadToEnd();
                // Workaround to solve CR/LF problem (github in some cases returns LF without CR...)
                fileData = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
                return fileData;
            }
        }
    }
}
