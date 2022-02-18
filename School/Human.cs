namespace School
{
    abstract class Human
    {
        private int age = 0;
        private string firstName = null;
        private string lastName = null;

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
    }
}
