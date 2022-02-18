namespace Animals
{
    public class Animal
    {
        protected int age = 0;
        protected string name = "";
        protected string gender = "";
        
        public virtual void AnimalSound()
        {
            System.Console.WriteLine("Striving for life sound.");
        }
    }
}
