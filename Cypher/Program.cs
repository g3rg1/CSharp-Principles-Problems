using System;

namespace Cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var cypher = Console.ReadLine();

            int cypherIndex = 0;
            int len = text.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write($"\\u{(ulong)cypher[cypherIndex] ^ text[i]:x4}");
                cypherIndex++;
                if (cypherIndex > cypher.Length - 1)
                {
                    cypherIndex = 0;
                }
            }
        }
    }
}
