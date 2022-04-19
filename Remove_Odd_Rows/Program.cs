using LoremNET;
using System;
using System.Collections.Generic;
using System.IO;

namespace Remove_Odd_Rows
{
    class Program
    {
        static void GetText(string path)
        {
            using (var wr = new StreamWriter(path))
            {
                var lineCount = Lorem.Number(10, 20);
                var index = 0;
                for (int i = 0; i < lineCount; i++)
                {
                    wr.WriteLine($"[{index}] {Lorem.Sentence(3, 7)}");
                    index++;
                }
            }
        }
        static void Main(string[] args)
        {
            var textPath = @"..\..\..\TextFile.txt";
            //GetText(textPath);
            var lines = new List<string>();

            using (var sr = new StreamReader(textPath))
            {
                var line = "";
                var index = 0;
                

                while ((line = sr.ReadLine()) != null)
                {
                    if (index % 2 == 0)
                    {
                        lines.Add(line);
                    }
                    index++;
                }
            }
            string clear = null;
            File.WriteAllText(textPath, clear);

            using (var sw = new StreamWriter(textPath))
            {
                foreach (var line in lines)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
