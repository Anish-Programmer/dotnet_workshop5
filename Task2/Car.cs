using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     internal class Car: Vehicle
    {
        // unique fields
        //property
        public int Seats { get; set; }



        // override method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
