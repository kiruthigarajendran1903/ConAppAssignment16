using System;


namespace ConAppAssignment16
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
                BankAccount bank = new BankAccount(38657856298769, "raj", 23000.56);
                Console.WriteLine("Initial Account Details:");
                bank.PrintAccountDetails();
            //deposit
            Console.WriteLine("Enter deposit amount");
            double deposit=double.Parse(Console.ReadLine());
            bank.Deposit(deposit);
            Console.WriteLine("After deposit");
            bank.PrintAccountDetails();
            //withdraw
            Console.WriteLine("Enter deposit amount");
            double withdraw = double.Parse(Console.ReadLine());
            bank.Withdraw(withdraw);
            Console.WriteLine("After withdraw");
            bank.PrintAccountDetails();

            Console.WriteLine("Final Bank Statement");
                bank.PrintAccountDetails();


            BankAccount bank1 = new BankAccount(49923587697298, "vishunu", 78000.56);
            Console.WriteLine("Initial Account Details:");
            bank1.PrintAccountDetails();

            //deposit
            Console.WriteLine("Enter deposit amount");
            double deposit1 = double.Parse(Console.ReadLine());
            bank1.Deposit(deposit1);
            Console.WriteLine("After deposit");
            bank1.PrintAccountDetails();
            //withdraw
            Console.WriteLine("Enter deposit amount");
            double withdraw1 = double.Parse(Console.ReadLine());
            bank1.Withdraw(withdraw1);
            Console.WriteLine("After withdraw");
            bank1.PrintAccountDetails();
            Console.WriteLine("Final Bank Statement");
            bank1.PrintAccountDetails();

            Console.ReadKey();

        }
    }
}
