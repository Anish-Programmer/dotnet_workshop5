using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"message: {message}");
        }

        // method overloading
        public void Print(int number)
        {
            Console.WriteLine($"number: {number}");
        }

        // method overloading
        public void Print(string message, int count)
        {
            Console.WriteLine($"message: {message}, count: {count}");
        }
    }
}
