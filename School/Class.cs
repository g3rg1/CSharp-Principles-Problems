using System.Collections.Generic;

namespace School
{
    class Class
    {
        private List<Teacher> teachers = null;
        private List<Worker> students = null;
        private char className = '\n';

        public Class(List<Teacher> teachers, List<Worker> students, char className)
        {
            Teachers = teachers;
            Students = students;
            ClassName = className;
        }
        public List<Teacher> Teachers
        {
            get => teachers;
            set => teachers = value;
        }
        public List<Worker> Students
        {
            get => students;
            set => students = value;
        }
        public char ClassName
        {
            get => className;
            set => className = value;
        }
    }
}
