using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
namespace Read_BIN_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileDir = @"SavedGame.bin";
            var bytes = File.ReadAllBytes(fileDir);

        }
    }
}
