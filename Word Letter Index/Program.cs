using System;

namespace Word_Letter_Index
{
    class Program
    {
        static char[] GetAlphabetIndex()
        {
            char[] alphabet = new char[26];
            int index = 0;
            for (var i = 'a'; i < 'z'; i++)
            {
                alphabet[index] = i;
                index++;
            }
            return alphabet;
        }
        static int[] GetLetterIndex(string word, char[] alphabet)
        {
            int[] letterIndex = new int[word.Length];
            int currentIndex = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        currentIndex = j;
                        break;
                    }
                }
                letterIndex[i] = currentIndex;
            }
            return letterIndex;
        }
        static void WriteResult(int[] letterIndex, string word, char[] alphabet)
        {
            Console.Write("alphabet letters:");
            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.Write($" ({alphabet[i]}[{i}])");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write($" {word[i]}");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < letterIndex.Length; i++)
            {
                Console.Write($" {word[i]}[{letterIndex[i]}]");
            }
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            char[] alphabet = GetAlphabetIndex();
            int[] letterIndex = GetLetterIndex(word, alphabet);
            WriteResult(letterIndex, word, alphabet);
        }
    }
}
