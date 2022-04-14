using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LoremNET;

namespace Enumerate_Rows
{
    class Program
    {
        static void GenerateText(string path)
        {
            var rng = new Random();
            var sb = new StringBuilder();

            for (int i = 0; i < rng.Next(7, 10); i++)
            {
                sb.Append($"{Lorem.Sentence(5, 10)}\r\n");
            }
            var text = sb.ToString();
            File.WriteAllText(path, text);
        }
        static void Main(string[] args)
        {
            var textFile = @"TextFile.txt";

            GenerateText(textFile);

            var lines = new List<string>();

            using (var read = new StreamReader(textFile))
            {
                var line = "";
                var rowIndex = 1;

                while ((line = read.ReadLine()) != null)
                {
                    lines.Add($"{rowIndex} {line}");
                    rowIndex++;
                }
            }

            using (var write = new StreamWriter(textFile))
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    write.WriteLine(lines[i]);
                }
            }

            using (var read = new StreamReader(textFile))
            {
                var line = "";
                while ((line = read.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
