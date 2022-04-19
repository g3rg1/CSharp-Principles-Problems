using LoremNET;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Replace_Substring_In_File
{
    class Program
    {
        static void GetText(string path)
        {
            using (var wr = new StreamWriter(path))
            {
                var lineCount = Lorem.Number(10, 20);

                for (int i = 0; i < lineCount; i++)
                {
                    wr.WriteLine(Lorem.Sentence(7, 14));
                }
            }
        }
        static void Main(string[] args)
        {
            var textPath = @"..\..\..\TextFile.txt";
            var regex = new Regex(@"(?<=\W|^)(start)(?=\W|$)");
            //GetText(textPath);

            using (var fs = new FileStream(textPath, FileMode.Open, FileAccess.ReadWrite))
            {
                using (var sr = new StreamReader(fs))
                {
                    var line = "";

                    using (var sw = new StreamWriter(fs))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            line = regex.Replace(line, "|-FINISH-|");
                            sw.WriteLine(line);
                        }
                    }
                }
            }

            var text = File.ReadAllText(textPath);
            Console.WriteLine(text);
        }
    }
}
