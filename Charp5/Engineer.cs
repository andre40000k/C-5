using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp5
{
    public class Engineer : In1, In2
    {
        private string position;
        private int work_experiance;

        public string Position { get => position; set => position = value; }
        public int Work_experiance { get => work_experiance; set => work_experiance = value; }
        public Engineer() { }
        public Engineer(string position, int work_experiance)
        {
            Position = position;
            Work_experiance = work_experiance;
        }

        public void Print_Engineer()
        {
            Console.WriteLine("\nДолжность: " + Position + "\nОпыт работы: " + Work_experiance);
        }
    }
}
