namespace Animals
{
    class Kitten : Animal
    {
        public Kitten(int age, string name, string gender)
        {
            base.age = age;
            base.name = name;
            base.gender = gender;
        }
        public override void AnimalSound()
        {
            System.Console.WriteLine("Mew!");
        }
        public override string ToString()
        {
            return $"Animal: Kitten, Age: {base.age}, Name: {base.name}, Gender: {base.gender}";
        }
    }
}
