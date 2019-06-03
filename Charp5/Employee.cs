using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp5
{
    public class Employee: Person
    {
        private string name;
        public string Name { get => name; set => name = value; }
        
        public Employee()
        {
        }
        public Employee(string name, string sex, int age, string composition, string position, int work_experiance)
            : base(sex, age, composition, position, work_experiance)
        {
                 Name = name;
        }

        public void Print_Employee()
        {
            Console.WriteLine("\nИмя: " + Name);
        }
    }
}
