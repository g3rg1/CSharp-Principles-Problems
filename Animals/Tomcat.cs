namespace Animals
{
    class Tomcat : Animal
    {
        public Tomcat(int age, string name, string gender)
        {
            base.age = age;
            base.name = name;
            base.gender = gender;
        }
        public override void AnimalSound()
        {
            System.Console.WriteLine("Mow.");
        }
        public override string ToString()
        {
            return $"Animal: Tomcat, Age: {base.age}, Name: {base.name}, Gender: {base.gender}";
        }
    }
}
