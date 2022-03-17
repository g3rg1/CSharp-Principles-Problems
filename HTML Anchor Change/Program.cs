using System;
using System.IO;
using System.Text;

namespace HTML_Anchor_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlText = File.ReadAllText("C:\\Users\\gergi\\source\\repos\\13. Strings\\HTML swap FORUM\\HTMLPage1.html");
            var sb = new StringBuilder();
            while (htmlText.Contains("<a"))
            {
                sb.Clear();
                int startIndex = htmlText.IndexOf("<a");
                int stopIndex = htmlText.IndexOf("</a>") + 4;
                int len = stopIndex - startIndex;
                sb.Append(htmlText.Substring(startIndex, len));
                sb.Replace("<a href=\"", "[URL=");
                sb.Replace("</a>", "[/URL]");
                sb.Replace("\">", "]");
                var result = sb.ToString();
                htmlText = htmlText.Remove(startIndex, len);
                htmlText = htmlText.Insert(startIndex, result);
            }
            Console.WriteLine(htmlText);
        }
    }
}
