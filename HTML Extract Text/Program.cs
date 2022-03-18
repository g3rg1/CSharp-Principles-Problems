using System;
using System.IO;
using System.Text;

namespace HTML_Extract_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("C:\\Users\\gergi\\Source\\Repos\\g3rg1" +
                "\\CSharp-Principles-Problems\\HTML Extract Text\\HTMLPage1.html");
            
            var startIndex = text.IndexOf("<title>") + 7;
            var stopIndex = text.IndexOf("</title>");
            var len = stopIndex - startIndex;
            var title = text.Substring(startIndex, len);

            startIndex = text.IndexOf("<body>") + 6;
            stopIndex = text.IndexOf("</body>");
            len = stopIndex - startIndex;
            var sb = new StringBuilder(text.Substring(startIndex, len));

            while(true)
            {
                startIndex = sb.
            }
        }
    }
}
