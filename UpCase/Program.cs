using System;

namespace UpCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text.Contains("<upcase>"))
            {
                int start = text.IndexOf("<upcase>");
                int stop = text.IndexOf("</upcase>");
                int len = Math.Abs(start - stop);
                var toInsert = text.Substring(start + 8, len - 8).ToUpper();
                text = text.Remove(start, len + 9);
                text = text.Insert(start, toInsert);
            }
            Console.WriteLine(text);
        }
    }
}
