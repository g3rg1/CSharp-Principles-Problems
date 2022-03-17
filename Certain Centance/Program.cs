using System;
using System.Collections.Generic;

namespace Certain_Centance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var word = Console.ReadLine();
            var centances = text.Split('.');
            var contain = new List<string>();
            for (int i = 0; i < centances.Length; i++)
            {
                centances[i] = centances[i].Trim();
                Console.WriteLine(centances[i]);
                if (centances[i].Contains(word))
                {
                    contain.Add(centances[i]);
                }
            }
            foreach (var centance in contain)
            {
                Console.WriteLine(centance);
            }
        }
    }
}
