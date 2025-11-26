using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal abstract class Vehicle // creating abstarct class
    {
        //  abstract members
        public abstract void StartEngine();
        public abstract void StopEngine();


        // concrete member
        public void Display() 
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
