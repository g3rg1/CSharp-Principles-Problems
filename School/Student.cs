using System;
using System.Collections;

namespace School
{
    class Student : Human, IComparable
    {
        private int uniqueNumber = 0;
        private int grade = 0;

        public Student(string firstName, string lastName, int age, int uniqueNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UniqueNumber = uniqueNumber;
        }
        public int UniqueNumber
        {
            get => uniqueNumber;
            set => uniqueNumber = value;
        }
        public int Grade
        {
            get => grade;
            set => grade = value;
        }
        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            return Grade.CompareTo(student.Grade);
        }
    }
}
