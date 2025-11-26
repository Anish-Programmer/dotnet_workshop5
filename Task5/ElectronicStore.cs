using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class ElectronicStore
    {
        // creating a list ElectronicDevice objects
        // readonly is intentionally added here for defensive programming
        //  only prevents reassignment of the field devices after construction.
        private readonly List<ElectronicDevice> devices = new();

        public void AddDevice(ElectronicDevice device) => devices.Add(device);

        public void RemoveDevice(ElectronicDevice device) => devices.Remove(device);

        public void ShowAllDeviceDetails() 
        {
            foreach (var dev in devices) 
            {
                dev.ShowInfo(); // polymorphic call

                // Down-cast to invoke child-specific behaviour
                if (dev is Laptop lp) // runtime type check + cast
                {
                    lp.TurnOnBattery();  // now we can use Laptop-only members
                }
                else if (dev is Smartphone sp) 
                {
                    sp.EnableCamera();
                }

                Console.WriteLine(); // black line between items

            }
        }
    }
}
