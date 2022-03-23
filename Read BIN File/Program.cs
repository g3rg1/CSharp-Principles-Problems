using System;
using System.IO;
namespace Read_BIN_File
{
    class Program
    {
        static byte[] ReadFile(string path)
        {
            byte[] bytes = null;
            try
            {
                bytes = File.ReadAllBytes(path);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return bytes;
        }
        static void WriteFile(byte[] bytes, string path)
        {
            try
            {
                if (bytes == null)
                {
                    throw new ArgumentNullException();
                }
                var file = File.Open(path, FileMode.Open);
                file.Write(bytes, 0, bytes.Length);
                file.Close();
                file.Dispose();
                Console.WriteLine("Done.");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            string pathToRead = @"SavedGame.bin";
            string pathToWrite = @"FileToWriteTo.bin";
            var readByte = ReadFile(pathToRead);
            WriteFile(readByte, pathToWrite);
            var writtenByte = ReadFile(pathToWrite);
            for (int i = 0; i < writtenByte.Length; i++)
            {
                Console.Write($" {writtenByte[i]}");
            }
            if(readByte == writtenByte && readByte != null)
            {
                Console.WriteLine("Files are the Same");
            }
            else
            {
                Console.WriteLine("Files are different");
            }
        }
    }
}
