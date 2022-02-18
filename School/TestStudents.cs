using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestStudents : Generator
    {
        private Student[] GetStudents()
        {
            Student[] students = new Student[10];
            int uniqueNumber = 1;
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(GenFirstName(),
                    GenLastName(), GenAge(), uniqueNumber);
                students[i].Grade = GenGrade();
                uniqueNumber++;
            }
            return students;
        }

        public void Print()
        {
            Student[] students = GetStudents();
            Array.Sort(students);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
                Console.WriteLine($"{student.Grade}");
                Console.WriteLine(new string('*', 80));
            }
        }
    }
}
