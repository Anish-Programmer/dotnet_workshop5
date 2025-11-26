using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Vehicle
    {
        // properties
        public string Brand { get; set; }
        public int Speed { get; set; }

        // methods
        public void Start() 
        {
            Console.WriteLine($"{Brand} is starting...");
        }

        // methods
        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping...");
        }

        // methods
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }
}
