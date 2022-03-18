using System;
using System.Text.RegularExpressions;

namespace Palindrome_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Abba is a music collective from Sweden. Unbeknownst to Jamal, Lamal took his slippers. " +
                "They kept the cellar locked, becouse nun Josephine drank all the wine last time. " +
                "He clicked on the file named  \"Virus.exe\" and his pc shut down. " +
                "At the pitstop, they refueled the racecar. " +
                "His character is a level 98 cleric named Hannah";
            //var rx = new Regex(@"\w");
            //var words = rx.Matches(text);
            text = text.ToLower();
            while (text.Contains(',') || text.Contains('\"'))
            {
                text = text.Replace(",", "");
                text = text.Replace("\"", "");
            }
            var words = text.Split(' ', '.');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                if(words[i] == "" || words[i].Length <= 1)
                {
                    continue;
                }
                bool isPalindrome = true;
                int endIndex = words[i].Length-1;
                for (int j = 0; j < words[i].Length / 2; j++)
                {
                    if (words[i][j] != words[i][endIndex])
                    {
                        isPalindrome = false;
                        break;
                    }
                    endIndex--;
                }
                if (isPalindrome)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
