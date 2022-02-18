using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = new string[,]{
            { "Sharo", "Lassie", "Rex", "Ramon", "Gustav"},
            { "Ligushka", "Beauty", "Beast", "Frank", "Hypnotoad"},
            { "Tom", "Becky", "mr.Huggums", "Helga", "LionKing"},
            };
            string[] gender = new string[] { "male", "female" };
            Random rng = new Random();
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < rng.Next(5,8); i++)
            {
                var currentAnimal = new Animal();
                int age = rng.Next(1, 5);
                int genderIndex = rng.Next(0, 2);
                int nameIndex = rng.Next(0, 5);
                switch (rng.Next(0, 5))
                {
                    case 0:
                        {
                            currentAnimal = new Dog(age, names[0, nameIndex], gender[genderIndex]);
                        }
                        break;
                    case 1:
                        {
                            currentAnimal = new Frog(age, names[1, nameIndex], gender[genderIndex]);
                        }
                        break;
                    case 2:
                        {
                            currentAnimal = new Cat(age, names[2, nameIndex], gender[genderIndex]);
                        }
                        break;
                    case 3:
                        {
                            currentAnimal = new Kitten(age, names[2, nameIndex], gender[genderIndex]);
                        }
                        break;
                    case 4:
                        {
                            currentAnimal = new Tomcat(age, names[2, nameIndex], gender[genderIndex]);
                        }
                        break;
                }
                animals.Add(currentAnimal);
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.AnimalSound();
                Console.WriteLine(new string('*', 80));
            }
        }
    }
}
