using LoremNET;
using System;
using System.IO;

namespace TextFile_Read_Odd_Rows
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"FileToReadFrom.txt";
            
            //using(var fileWrite = new StreamWriter(fileName))
            //{
            //    for (int i = 0; i < 42; i++)
            //    {
            //        fileWrite.WriteLine($"[{i}] {Lorem.Sentence(5, 10)}");
            //    }
            //}

            using (var fileRead = new StreamReader(fileName))
            {
                string line;
                var lineIndex = 0;
                while((line = fileRead.ReadLine()) != null)
                {
                    if(lineIndex%2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineIndex++;
                }
            }
        }
    }
}
