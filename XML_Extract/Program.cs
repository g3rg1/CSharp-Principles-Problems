using System;
using System.Collections.Generic;
using System.IO;
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

            //GenXMLData(filePath);
            var extractedText = new List<string>();

            using (var sr = new StreamReader(filePath))
            {
                var line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    int currentLenIndex = 0;
                    int start = 0;
                    int stop = 0;
                    while (line.Length <= currentLenIndex)
                    {

                        start = line.IndexOf('>', currentLenIndex);
                        stop = line.IndexOf('<', start);
                        var len = stop - (start + 1);
                        currentLenIndex += stop;
                        var currentString = line.Substring(start, len);
                        extractedText.Add(currentString);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", extractedText));
        }
    }
}
