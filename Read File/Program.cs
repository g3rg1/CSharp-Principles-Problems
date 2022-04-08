using System;
using System.IO;
namespace Read_File
{
    class Program
    {
        static void ReadFile(string path)
        {
            try
            {
                var file = File.ReadAllText(path);
                Console.WriteLine(file);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File at the given path does not exist.");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path :");
            var path = $@"{Console.ReadLine()}";
            ReadFile(path);
        }
    }
}
