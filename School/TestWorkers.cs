using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestWorkers : Generator
    {
        private Worker[] GetWorkers()
        {
            Worker[] workers = new Worker[10];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker(GenFirstName(),
                    GenLastName(), GenAge(), GenSalary(), GenWorkHours());
            }
            return workers;
        }
        public void Print()
        {
            Worker[] workers = GetWorkers();
            Array.Sort(workers);
            Array.Reverse(workers);
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName}");
                Console.WriteLine($"Salary:{worker.Salary:F2}$ WorkHours:{worker.WorkHours}");
                Console.WriteLine($"PayPerHour:{Math.Round(worker.PayPerHour(), 2)}$");
                Console.WriteLine(new string('*', 80));
            }
        }
    }
}
