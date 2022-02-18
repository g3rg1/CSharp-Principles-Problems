
using System;

namespace School
{
    abstract class Generator
    {
        private Random rng = new Random();
        private string[] firstNames = { "Abu", "George", "Sindey", "Frank", "Theodor", "Tim" };
        private string[] lastNames = { "Jefferson", "Dick", "Mcnamara", "O'reylie", "Zuckerberg", "Hanks" };

        public string GenFirstName()
        {
            string fN = firstNames[rng.Next(0, 6)];
            return fN;
        }
        public string GenLastName()
        {
            string lN = lastNames[rng.Next(0, 6)];
            return lN;
        }
        public int GenAge()
        {
            return rng.Next(8, 19);
        }

        public int GenGrade()
        {
            return rng.Next(2, 7);
        }
        public double GenSalary()
        {
            double salary = rng.NextDouble() * rng.Next(50, 150);
            return salary;
        }
        public int GenWorkHours()
        {
            return rng.Next(40, 169);
        }
    }
}
