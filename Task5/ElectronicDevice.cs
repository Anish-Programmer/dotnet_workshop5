using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal abstract class ElectronicDevice // abstract class
    {
        private string brand;
        private decimal price;

        public string Brand
        {
            //get { return brand; }
            //set { brand = value; }
            get => brand;
            set => brand = value;

            // both syntax will work the same
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }


        // constructor
        protected ElectronicDevice(string brand, decimal price) 
        {
            this.brand = brand;
            this.price = price;
        }


        // abstract method
        public abstract void ShowInfo();


    }
}
