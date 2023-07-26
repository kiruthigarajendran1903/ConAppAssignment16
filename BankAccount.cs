using System;


namespace ConAppAssignment16
{
    public class BankAccount
    {
        long accountNumber;
        double balance;
        public BankAccount(long accountNumber,string accountHolderName,double balance)
        {
            this.accountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.balance = balance;
        }
      
        public long AccountNumber 
        { 
            get
            {
                return accountNumber;
            }
        }
        private string accountHolderName;
       

        public string AccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine ("Deposit amount must be greater than zero.");
            }

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }

            if (balance < amount)
            {
                Console.WriteLine ("Insufficient funds for withdrawal.");
            }

            balance -= amount;
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {balance:F2}");
            Console.ReadKey();
        }
    }
}

