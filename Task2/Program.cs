namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object of derived Car class
            Car car = new Car 
            { 
                Brand = "Toyota",
                Speed = 100,
                Seats = 5
            };

            Console.WriteLine("--- Car Information ---");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            // creating object of derived Motorcycle class
            Motorcycle motorcycle = new Motorcycle
            {
                Brand = "Harley-Davidson",
                Speed = 80,
                HasCarrier = true
            };

            Console.WriteLine("--- Motorcycle Information ---");
            motorcycle.Start();
            motorcycle.DisplayInfo();
            motorcycle.Stop();

            Console.ReadLine();
        }
    }
}
