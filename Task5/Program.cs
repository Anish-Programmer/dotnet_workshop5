namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an object for ElectronicsStore class
            ElectronicStore store = new ElectronicStore();

            // creating objects of Laptop and Smartphone
            Laptop laptop1 = new Laptop("Dell", 899.99m);
            Smartphone smartphone1 = new Smartphone("Samsung", 749.50m);

            // adding Laptop and SmartPhone object in store
            store.AddDevice(laptop1);
            store.AddDevice(smartphone1);

            store.ShowAllDeviceDetails();
        }
    }
}
