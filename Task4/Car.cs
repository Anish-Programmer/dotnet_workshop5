using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Car : Vehicle // inheritance
    {
        public override void StartEngine()
        {
            Console.WriteLine("car engine started...");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
}
