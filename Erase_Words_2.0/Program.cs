using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using LoremNET;
namespace Erase_Words_2._0
{
    class Program
    {
        static void GenText(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                var count = Lorem.Number(10, 15);
                for (int i = 0; i < count; i++)
                {
                    sw.WriteLine(Lorem.Sentence(7, 13));
                }
            }
        }
        static void GenWords(string path)
        {
            var words = new string[] { "et", "ipsum", "orci", "erat" };

            using (var sw = new StreamWriter(path))
            {
                for (int i = 0; i < words.Length; i++)
                {
                    sw.WriteLine(words[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            var textFilePath = @"..\..\..\text.txt";
            var wordFilePath = @"..\..\..\words.txt";
            var tempFilePath = @"..\..\..\temp.txt";
            var resultFilePath = @"..\..\..\result.txt";

            GenText(textFilePath);
            //GenWords(wordFilePath);
            
            try
            {
                var line = "";
                var words = new List<string>();

                using (var sr = new StreamReader(wordFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        words.Add(line);
                    }
                }

                var wordCount = new Dictionary<string, int>();
                
                using (var sr = new StreamReader(textFilePath))
                {
                    using (var sw = new StreamWriter(tempFilePath))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            for (int i = 0; i < words.Count; i++)
                            {
                                wordCount.TryAdd(words[i], 0);

                                while (line.Contains(words[i]))
                                {
                                    var toChange = line.IndexOf(words[i]);
                                    line = line.Remove(toChange, words[i].Length);
                                    wordCount[words[i]]++;
                                }
                            }
                            sw.WriteLine(line);
                        }
                    }
                }

                var sortedDict = from word in wordCount orderby word.Value descending select word;

                using (var sw = new StreamWriter(resultFilePath))
                {
                    foreach (var word in sortedDict)
                    {
                        sw.WriteLine($"\"{word.Key}\" deleted {word.Value} times.");
                    }
                }

                File.Copy(tempFilePath, textFilePath, true);
                File.Delete(tempFilePath);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
