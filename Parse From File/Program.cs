using System;
using System.Collections.Generic;
using System.IO;

namespace Parse_From_File
{
    class Program
    {
        static double[] ParseFromFile(string path)
        {
            var nums = new List<double>();

            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    while (reader.ReadLine() != null)
                    {
                        var line = reader.ReadLine();
                        var strings = line.Split(' ');
                        foreach (var num in strings)
                        {
                            nums.Add(double.Parse(num));
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        static void Main(string[] args)
        {
            var path = @"FileToParse.txt";

        }
    }
}
