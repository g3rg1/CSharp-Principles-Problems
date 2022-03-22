using System;
using System.IO;

namespace Read_File_Name
{
    class Program
    {
        static string ReadFileName(string path)
        {
            string fileName = null;
            try
            {
                fileName =  Path.GetFileName(path);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return fileName;
        }
        static void Main(string[] args)
        {
            var path = "C:\\Users\\gergi\\Source\\Repos\\g3rg1\\CSharp-Principles-Problems\\Read File Name\\SomeTextFile.txt";
            var fileName = ReadFileName(path);
            Console.WriteLine(fileName);
        }
    }
}
