using System;

namespace NamespaceImportTest
{
    public class Dog
    {
        private string name;

        public Dog()
        {

        }
        public Dog(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public void Bark()
        {
            Console.WriteLine("{0} said: grr, woof!", name ?? "[Unnamed dog]");
        }
    }
    
}
