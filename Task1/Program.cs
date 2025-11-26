namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an BankAccount object
            BankAccount account = new BankAccount("ACC11", 7000);

            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance}");

            // Depositing money
            account.Deposit(2000);

            // withdrawing money
            account.Withdraw(1000);

            // printing final balance
            Console.WriteLine("Remaining Balance: "+ account.Balance);

            Console.ReadLine();
        }
    }
}
