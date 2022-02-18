namespace Animals
{
    class Dog : Animal
    {
        public Dog(int age, string name, string gender)
        {
            base.age = age;
            base.name = name;
            base.gender = gender;
        }
        public override void AnimalSound()
        {
            System.Console.WriteLine("Woof!");
        }
        public override string ToString()
        {
            return $"Animal: Dog, Age: {base.age}, Name: {base.name}, Gender: {base.gender}";
        }
    }
}
