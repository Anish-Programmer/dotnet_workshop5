using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Motorcycle: Vehicle
    {
        // unique fields
        // property
        public bool HasCarrier { get; set; }

        // override method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}
