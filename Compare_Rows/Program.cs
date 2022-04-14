using System;
using System.IO;

namespace Compare_Rows
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFile = @"..\..\..\FirstFile.txt";
            var secondFile = @"..\..\..\SecondFile.txt";
            int sameRows = 0;
            int differentRows = 0;

            using (var readFirst = new StreamReader(firstFile))
            {
                using (var readSecond = new StreamReader(secondFile))
                {
                    while(true)
                    {
                        var firstFileLine = readFirst.ReadLine();
                        var secondFileLine = readSecond.ReadLine();
                        if(firstFileLine == null || secondFileLine == null)
                        {
                            break;
                        }
                        else if(firstFileLine == secondFileLine)
                        {
                            sameRows++;
                        }
                        else
                        {
                            differentRows++;
                        }
                    }
                }
            }
            Console.WriteLine($"same rows: {sameRows}, different: {differentRows}");
        }
    }
}
