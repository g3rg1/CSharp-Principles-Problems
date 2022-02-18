namespace Animals
{
    class Cat : Animal
    {
        public Cat(int age, string name, string gender)
        {
            base.age = age;
            base.name = name;
            base.gender = gender;
        }
        public override void AnimalSound()
        {
            System.Console.WriteLine("Meow!");
        }
        public override string ToString()
        {
            return $"Animal: Cat, Age: {base.age}, Name: {base.name}, Gender: {base.gender}";
        }
    }
}
