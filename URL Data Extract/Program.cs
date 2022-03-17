using System;

namespace URL_Data_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = Console.ReadLine();
            var components = url.Split("://");
            var protocol = components[0];
            components = components[1].Split("/");
            var server = components[0];
            var resourse = components[1];
            Console.WriteLine($"{protocol} {server} {resourse}");
        }
    }
}
