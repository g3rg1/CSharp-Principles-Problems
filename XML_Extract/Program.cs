using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace XML_Extract
{
    class Program
    {
        static void GenXMLData(string filePath)
        {
            var student = new Student();
            var interestsArr = new string[] { "Games", "C#", "Java" };
            student.Name = "Pesho";
            student.Age = 21;
            student.Interest = new List<string>();

            for (int i = 0; i < interestsArr.Length; i++)
            {
                student.Interest.Add(interestsArr[i]);
            }

            var x = new XmlSerializer(typeof(Student));
            using (var sw = new StreamWriter(filePath))
            {
                x.Serialize(sw, student);
            }
        }
        static void Main(string[] args)
        {
            var filePath = @"..\..\..\XMLFile.xml";
            var rx = new Regex(@"(?<=\>)(.*?)(?=\<)");
            var extractedText = new List<string>();

            //GenXMLData(filePath);

            using (var sr = new StreamReader(filePath))
            {
                var line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    var matches = rx.Matches(line);
                    foreach (var match in matches)
                    {
                        extractedText.Add(match.ToString());
                    }
                }
            }
            Console.WriteLine(string.Join(" ", extractedText));
        }
    }
}
