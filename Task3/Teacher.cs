using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Teacher
    {
        // property 
        public string? Name { get; set; }

        //method
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // non-virtual → automatically sealed against overriding
        public void SalaryInfo() 
        {
            Console.WriteLine("Teacher salary cannot be overriden.");
        }
    }
}
