using System;
using System.Text;

namespace Reverse_text
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var words = text.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append($" {words[i]}");
            }
            var reverseText = sb.ToString();
            reverseText.TrimStart();
            Console.WriteLine(reverseText);
        }
    }
}
