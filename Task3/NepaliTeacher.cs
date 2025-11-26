using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class NepaliTeacher: Teacher // inheritance
    {
        public override void Teaching()  // method overiding
        {
            Console.WriteLine("NepaliTeacher teaches in Nepalli");
        }
    }
}
