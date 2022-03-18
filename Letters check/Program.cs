using System;
using System.Collections.Generic;
using System.Text;

namespace Letters_check
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "This is a test text. It is written so that the program has something to work with.";
            text = text.ToLower();
            var sb = new StringBuilder();
            var letters = new Dictionary<char, int>();
            sb.Append(text);
            sb.Replace(" ", "");
            sb.Replace(".", "");
            text = sb.ToString();

            Console.WriteLine(text);
            for (int i = 0; i < text.Length; i++)
            {
                if(letters.ContainsKey(text[i]))
                {
                    letters[text[i]]++; 
                }
                else
                {
                    letters.Add(text[i], 1);
                }
            }
            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} {letter.Value}");
            }
        }
    }
}
