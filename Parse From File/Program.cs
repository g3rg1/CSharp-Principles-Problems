using Read_File_Name;
using System;
using System.Collections.Generic;
using System.IO;

namespace Parse_From_File
{
    class Program
    {
        static List<double> ParseFromFile(string path)
        {
            var nums = new List<double>();

            try
            {
                using (StreamReader reader = File.OpenText(path))
                {

                    double value;
                    int lineIndex = 0;
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if(line == null)
                        {
                            break;
                        }
                        lineIndex++;
                        var strings = line.Split(' ');
                        foreach (var num in strings)
                        {
                            if(double.TryParse(num, out value))
                            {
                                nums.Add(value);
                            }
                            else
                            {
                                throw new FileParseExeption("Failed to parse from file.", path, lineIndex);
                            }
                        }
                    }
                }
            }
            catch (FileParseExeption ex)
            {
                //nums.Clear();
                Console.WriteLine($"{ex.Message} File name: {ex.FileName}, at line {ex.Row}");
            }
            return nums;
        }
        static void Main(string[] args)
        {
            var path = @"FileToParse.txt";
            var nums = ParseFromFile(path);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
