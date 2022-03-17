using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "";
            var dict = new Dictionary<string, string>();
            var key = "";
            Console.WriteLine("*Input data.To exit, type \'q\'*");
            while (true)
            {
                text = Console.ReadLine();
                if (text.ToLower() == "q")
                {
                    break;
                }
                var keyValuePair = text.Split('-');
                dict.Add(keyValuePair[0].Trim(), keyValuePair[1].Trim());
            }
            Console.WriteLine("*Enter a Keyword*");

            while (true)
            {

                key = Console.ReadLine();
                if (key.ToLower() == "q")
                {
                    break;
                }
                var value = "";
                bool getKey = dict.TryGetValue(key, out value);
                if (getKey)
                {
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("Word is missing in Dictionary.");
                }
            }
        }
    }
}
