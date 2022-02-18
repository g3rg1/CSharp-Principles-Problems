using System.Collections.Generic;

namespace School
{
    class Teacher : Human
    {
        private List<Subject> subjects = null;
        public Teacher(string firstname, string lastName, int age, List<Subject> subjects)
        {
            FirstName = firstname;
            LastName = lastName;
            Age = age;
            Subjects = subjects;
        }
        public List<Subject> Subjects
        {
            get => subjects;
            set => subjects = value;
        }
    }
}
