using System;
using System.Text;

namespace Bracket_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToCheck = Console.ReadLine();
            var len = stringToCheck.Length;
            StringBuilder brackets = new StringBuilder();
            bool correct = true;
            for (int i = 0; i < len; i++)
            {
                char current = stringToCheck[i];
                if (current == '(' || current == ')')
                {
                    brackets.Append(current);
                }
            }

            len = brackets.Length;

            if (len % 2 == 0)
            {
                while (len > 2)
                {
                    brackets.Replace("()", "");
                    len = brackets.Length;
                }
                var check = brackets.ToString();
                if (check == ")(")
                {
                    correct = false;
                }
            }
            else
            {
                correct = false;
            }

            if (correct)
            {
                Console.WriteLine("Brackets are correct.");
            }
            else
            {
                Console.WriteLine("Brackets are incorrect.");
            }
        }
    }
}
