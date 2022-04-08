using System;

namespace Read_File_Name
{
    class FileParseExeption : Exception
    {
        private string fileName;
        private int row;

        public FileParseExeption(string message, string fileName, int row)
            : base(message)
        {
            this.fileName = fileName;
            this.row = row;
        }

        public FileParseExeption(string message, Exception inner, string fileName, int row)
            : base(message, inner)
        {
            this.fileName = fileName;
            this.row = row;
        }
        public string FileName 
        { 
            get => fileName;
        }
        public int Row
        {
            get => row;
        }
    }
}
