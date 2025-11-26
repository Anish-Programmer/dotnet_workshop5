namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object for Printer class
            Printer printer = new Printer();
            Console.WriteLine("Printer printing method overlaod: ");
            printer.Print("Hello"); // string overload
            printer.Print(42); // int overload
            printer.Print("Hi", 2); // string + int overload

            Console.WriteLine();

            // creating object for Teacher base class
            NepaliTeacher nt = new NepaliTeacher { Name="Hari" };
            EnglishTeacher et = new EnglishTeacher { Name = "John" };
            Console.WriteLine("-----NepaliTeacher------");
            nt.Teaching();
            nt.SalaryInfo();
            


            Console.WriteLine("\n-----EnglishTeacher----");
            et.Teaching(); // uses base calss implementation
            et.SalaryInfo();


        }
    }
}
