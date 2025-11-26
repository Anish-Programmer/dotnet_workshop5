using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Laptop: ElectronicDevice // inheritance
    {
        // constructor
        public Laptop(string brand, decimal price) : base (brand, price){ }

        public void TurnOnBattery() 
        {
            Console.WriteLine("Laptop battery is now ON.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand : {Brand}, Price: {Price:C}");
        }
    }
}
