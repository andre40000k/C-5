using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp5
{
    public class Person : Working
    {
        private string sex;
        private int age;
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value >= 18 && value <= 75 ? value : 18; }

        public Person(){}
        public Person(string sex, int age, string composition, string position, int work_experiance)
            :base(composition, position, work_experiance)
        {
            Sex = sex;
            Age = age;
        }

        public void Print_Person()
        {
            Console.WriteLine("\nПол: " + Sex + "\nВозраст: " + Age);
        }
    }
}
