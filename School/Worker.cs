using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Worker : Human, IComparable
    {
        private double salary = 0.0;
        private int workHours = 0;

        public Worker(string firstName, string lastName,int age, double salary, int workHours)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
            WorkHours = workHours;
        }
        public double Salary
        {
            get => salary;
            set => salary = value;
        }
        public int WorkHours
        {
            get => workHours;
            set => workHours = value;
        }
        public double PayPerHour()
        {
            var pay = salary / workHours;
            return pay;
        }
        public int CompareTo(object obj)
        {
            Worker worker = obj as Worker;
            return PayPerHour().CompareTo(worker.PayPerHour());
        }
    }
}
