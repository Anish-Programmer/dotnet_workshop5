namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object for derived class
            Car myCar = new Car();
            Bike myBike = new Bike();

            Console.WriteLine("---Car ------");
            myCar.Display();
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine("\n---Bike-----");
            myBike.Display();
            myBike.StartEngine();
            myBike.StopEngine();
        }
    }
}
