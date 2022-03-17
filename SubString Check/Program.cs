using System;

namespace SubString_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var key = Console.ReadLine().ToLower();
            int occured = 0;
            int startIndex = 0;

            if (text.Contains(key))
            {
                while (startIndex <= text.Length - 1)
                {
                    int found = 0;
                    found = text.IndexOf(key, startIndex);
                    if (found >= 0)
                    {
                        startIndex = found + key.Length - 1;
                    }
                    else
                    {
                        break;
                    }
                    occured++;
                }
            }
            Console.WriteLine(occured);
        }
    }
}
