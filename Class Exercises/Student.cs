using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        private string name = null;
        private int year = 0;
        private string specialty = null;
        private string university = null;
        private string email = null;
        private string phonenum = null;
        private static int studentCount = 0;

        public Student()
        {
            studentCount++;
        }
        public Student(string name, int year, string specialty,
            string university, string email, string phonenum)
        {
            this.name = name;
            this.year = year;
            this.specialty = specialty;
            this.university = university;
            this.email = email;
            this.phonenum = phonenum;
            studentCount++;
        }
        public Student(string name, int year, string specialty,
            string university)
        {
            this.name = name;
            this.year = year;
            this.specialty = specialty;
            this.university = university;
            studentCount++;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }
        public string Specialty
        {
            get => specialty;
            set => specialty = value;
        }
        public string University
        {
            get => university;
            set => university = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Phonenum
        {
            get => phonenum;
            set => phonenum = value;
        }
        public int StudentCount
        {
            get => studentCount;
            set => studentCount = value;
        }
        public void StudentInfo()
        {
            Console.WriteLine(new string('*', Name.Length));
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Year: {Year}");
            Console.WriteLine($"Student Specialty: {Specialty}");
            Console.WriteLine($"Student University: {University}");
            Console.WriteLine($"Student Email: {Email}");
            Console.WriteLine($"Student Phonenum: {Phonenum}");
        }
    }
}
