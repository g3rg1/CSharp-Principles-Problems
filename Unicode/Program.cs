﻿using System;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"\\u{(int)input[i]:x4}");
            }
        }
    }
}
