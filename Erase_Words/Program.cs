using System;
using System.Collections.Generic;
using System.IO;

namespace Erase_Words
{
    class Program
    {
        static void ResetTextFile(string seedFilePath, string textFilePath)
        {
            File.Copy(seedFilePath, textFilePath, true);
        }
        static void Main(string[] args)
        {
            var seedFilePath = @"..\..\..\SeedFile.txt";
            var textFilePath = @"..\..\..\TextFile.txt";
            var tempFilePath = @"..\..\..\TempFile.txt";

            ResetTextFile(seedFilePath, textFilePath);

            using (var sr = new StreamReader(textFilePath))
            {

                using (var sw = new StreamWriter(tempFilePath))
                {
                    var line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        var words = line.Split(' ');

                        for (int i = 0; i < words.Length; i++)
                        {
                            var wordToCheck = words[i].ToLower();

                            if (wordToCheck.Contains("test"))
                            {
                                if (wordToCheck.IndexOf("test") == 0)
                                {
                                    if (!char.IsLetter(wordToCheck[wordToCheck.Length - 1]))
                                    {
                                        words[i] = $"{wordToCheck[wordToCheck.Length - 1]}";
                                    }
                                    else
                                    {
                                        words[i] = "";
                                    }
                                }
                            }
                        }
                        line = string.Join(" ", words);
                        sw.WriteLine(line);
                    }
                }
            }

            File.Copy(tempFilePath, textFilePath, true);
            File.Delete(tempFilePath);
        }
    }
}
