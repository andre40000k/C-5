using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Charp5
{
    class Program
    {
        delegate void Met();
        [DllImport("winmm.dll", EntryPoint = "sndPlaySound")]
        public static extern long PlaySound(string fileName, long flags);
        static void Main(string[] args)
        {
            Met point;

            Employee employee = new Employee("Басков", "Мужской", 50, "Золотая Чаша", "Певец", 30);

            point = employee.Print_Employee;
            point += employee.Print_Person;
            point += employee.Print_Working;
            point += employee.Print_Engineer;
            
            point();
            PlaySound("GoldCup.wav", 0);
        }
        
    }
}
