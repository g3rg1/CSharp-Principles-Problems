using LoremNET;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sort_Names_From_File
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var namesFilepath = @"..\..\..\NamesFIle.txt";
            var sortedNamesPath = @"..\..\..\SortedNamesFIle.txt";

            var names = new List<string>();

            using (var sr = new StreamReader(namesFilepath))
            {
                var line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }
            names.Sort();

            using (var sw = new StreamWriter(sortedNamesPath))
            {
                foreach (var name in names)
                {
                    sw.WriteLine(name);
                }
            }
        }
    }
}
