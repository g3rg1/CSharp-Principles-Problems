using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HTML_Extract_Text
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = File.ReadAllText("C:\\Users\\Bankera\\Source\\Repos\\g3rg1" +
                "\\CSharp-Principles-Problems\\HTML Extract Text\\HTMLPage1.html");

            var rx = new Regex(@"\</[a-z]>", RegexOptions.IgnoreCase);

            var startIndex = text.IndexOf("<title>") + 7;
            var stopIndex = text.IndexOf("</title>");
            var len = stopIndex - startIndex;
            var title = text.Substring(startIndex, len);

            startIndex = text.IndexOf("<body>") + 6;
            stopIndex = text.IndexOf("</body>");
            len = stopIndex - startIndex;
            var body = text.Substring(startIndex, len);

            while(rx.IsMatch(body))
            {
                startIndex = body.IndexOf("<");
                stopIndex = body.IndexOf(">");
                len = stopIndex - startIndex + 1;
                body = body.Remove(startIndex, len);
            }
            body = body.Replace("\r\n", "");
            var bodyParts = body.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Title: {title}");
            Console.WriteLine("Body: ");
            Console.WriteLine(string.Join(" ", bodyParts));
        }
    }
}
