using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Smartphone: ElectronicDevice // inheritance 
    {
        // constructor
        public Smartphone(string brand, decimal price) : base (brand, price) { }


        // extra method 
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is now ENABLED.");
        }

        public override void ShowInfo() // method overidding
        {
            Console.WriteLine($"Smartphone - Brand: {Brand}, Price: {Price:C}");
        }

    }   
}
