using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
namespace Read_BIN_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileDir = @"C:\Users\Bankera\Source\Repos\g3rg1\CSharp-Principles-Problems\Read BIN File\SavedGame.bin";
            string fileToWriteTo = @"C:\Users\Bankera\Source\Repos\g3rg1\CSharp-Principles-Problems\Read BIN File\FileToWriteTo.bin";
            var bytes = File.ReadAllBytes(fileDir);
            var file = File.Open(fileToWriteTo, FileMode.Open);
            file.Write(bytes, 0, bytes.Length);
            file.Close();
            file.Dispose();
            Console.WriteLine("Done.");
        }
    }
}
