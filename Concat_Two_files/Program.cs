using LoremNET;
using System;
using System.Collections.Generic;
using System.IO;

namespace Concat_Two_files
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePaths = new string[] {@"FirstFile.txt", @"SecondFile.txt"};
            var exitFile = @"ExitFile.txt";

            WriteFiles(filePaths);
            
            using(var fileWrite = new StreamWriter(exitFile))
            {
                for (int i = 0; i < filePaths.Length; i++)
                {
                    using (var fileread = new StreamReader(filePaths[i]))
                    {
                        string line;

                        while ((line = fileread.ReadLine()) != null)
                        {
                            fileWrite.WriteLine(line);
                        }
                    }
                }
            }
            var textExitFile = File.ReadAllText(exitFile);
            Console.WriteLine(textExitFile);
        }
        static void WriteFiles(string[] filePaths)
        {
            var rng = new Random();

            for (int i = 0; i < filePaths.Length; i++)
            {
                using (var writer = new StreamWriter(filePaths[i]))
                {
                    var textLines = new List<string>();

                    for (int j = 0; j < rng.Next(2, 4); j++)
                    {
                        textLines.Add(Lorem.Sentence(2, 6));
                    }

                    textLines.Add($"End of FIle[{i + 1}].");

                    for (int j = 0; j < textLines.Count; j++)
                    {
                        writer.WriteLine(textLines[j]);
                    }
                }
            }
        }
    }
}
