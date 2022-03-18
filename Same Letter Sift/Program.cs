using System;
using System.Text;

namespace Same_Letter_Sift
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "aaaaabbbbbcdddeeeedssaa";
            var sb = new StringBuilder(text.ToLower());

            var index = 0;
            while (true)
            {
                if(sb[index] == sb[index + 1])
                {
                    sb.Remove(index + 1, 1);
                }
                else
                {
                    index++;
                }

                if (index == sb.Length - 1)
                {
                    break;
                }
            }
            text = sb.ToString();
            Console.WriteLine(text);
        }
    }
}
