using LoremNET;
using System;
using System.IO;

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
            //GetText(textPath);
            
        }
    }
}
