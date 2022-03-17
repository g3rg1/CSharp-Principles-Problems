using System;

namespace Forbidden_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var wordsText = Console.ReadLine();
            var words = wordsText.Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                while (text.Contains(words[i]))
                {
                    text = text.Replace(words[i], new string('*', words[i].Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
