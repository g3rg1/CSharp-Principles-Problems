using System;
using System.Collections.Generic;
using System.Text;
using LoremNET;

namespace Word_Alphabet_Sort_and_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Lorem.Paragraph(3, 5, 4);

            Console.WriteLine(text);
            Console.WriteLine();

            var sb = new StringBuilder(text);
            sb.Replace(".", "");
            sb.Replace(",", "");
            text = sb.ToString().ToLower();
            var words = new List<string>(text.Split(' '));
            words.Sort();
            var sortedWords = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if(sortedWords.ContainsKey(words[i]))
                {
                    sortedWords[words[i]]++;
                }
                else
                {
                    sortedWords.Add(words[i], 1);
                }
            }
            foreach (var word in sortedWords)
            {
                Console.WriteLine($" {word.Key} {word.Value}");
            }
        }
    }
}
