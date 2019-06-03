using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp5
{
    public class Working: Engineer
    {
        private string composition;
        public string Composition { get => composition; set => composition = value; }

        public Working() { }
        public Working(string composition, string position, int work_experiance)
            :base(position, work_experiance)
        {
            Composition = composition;
        }

        public void Print_Working()
        {
            Console.WriteLine("\nКомпозиция: " + composition);
        }
    }
}
