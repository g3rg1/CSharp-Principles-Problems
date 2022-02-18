using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal
    {
        public Frog(int age, string name, string gender)
        {
            base.age = age;
            base.name = name;
            base.gender = gender;
        }
        public override void AnimalSound()
        {
            System.Console.WriteLine("Rrribbit.");
        }
        public override string ToString()
        {
            return $"Animal: Frog, Age: {base.age}, Name: {base.name}, Gender: {base.gender}";
        }
    }
}
