using System;

namespace Week2Day3Demos.AssignmentSolution
{
    /// <summary>
    /// Written by Avinash Tauro
    /// Only for reference. Some items used in this may not be covered in the course yet.
    /// This was done just to give the attendees and idea of how to approach an OOP assignment
    /// How to go through the thought process and brainstorm with partners.
    /// </summary>
    internal enum AccountType
    {
        SavingsAccount,
        CurrentAccount
    }
    internal class Account
    {
        protected int Balance;

        private readonly string _customerName;
        private readonly string _accountNumber;
        private readonly AccountType _accountType;

        protected Account(string customerName, string accountNumber, AccountType accountType, int openingBalance)
        {
            _customerName = customerName;
            _accountNumber = accountNumber;
            _accountType = accountType;

            Balance = openingBalance;
        }

        public virtual void Withdraw(int amount)
        {
            Balance -= amount;
            // 100 lines of code
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit successful!! Current balance = {Balance}");
        }

        public virtual bool IsBelowMinimumBalance(int amount)
        {
            return Balance - amount < 0;
        }

        public virtual void ComputeAndDepositInterest()
        {
            //no interest to by default
            Console.WriteLine("Your account is not eligible for interest!!");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance for {_customerName} {_accountType}, account no: {_accountNumber} = {Balance}");
        }

        public virtual void IssueChequeBook()
        {
            Console.WriteLine("ChequeBook Issued");
        }
    }

    internal class SavingsAccount : Account
    {
        public SavingsAccount(string customerName, string accountNumber, int openingBalance) : 
            base(customerName, accountNumber, AccountType.SavingsAccount, openingBalance)
        {
        }

        public override void Withdraw(int amount)
        {
            if (IsBelowMinimumBalance(amount))
                Console.WriteLine("Withdrawal failed!! You do not have enough funds!!");
            else
            {
                Console.WriteLine($"Withdrawal of {amount} successful. Current balance={Balance}");
                base.Withdraw(amount);
            }
        }

        public override void IssueChequeBook()
        {
            Console.WriteLine("ChequeBook facility not available in your account!!");
        }

        public override void ComputeAndDepositInterest()
        {
            const int interest = 100;
            Console.WriteLine($"You have earned compound interest = {interest}!!");

            Deposit(interest);
        }
    }

    internal class CurrentAccount : Account
    {
        private const int MinimumBalance = 1000;
        private const int ServiceCharge = 300;

        public CurrentAccount(string customerName, string accountNumber, int openingBalance) :
            base(customerName, accountNumber, AccountType.CurrentAccount, openingBalance)
        {
        }

        public override bool IsBelowMinimumBalance(int amount)
        {
            return Balance - amount < MinimumBalance;
        }

        public override void Withdraw(int amount)
        {
            if (IsBelowMinimumBalance(amount))
            {
                Console.WriteLine("Withdrawal failed!! You do not have enough funds!! Service fee charged from account");
                Balance -= ServiceCharge;
            }
            else
            {
                Console.WriteLine($"Withdrawal of {amount} successful. Current balance={Balance}");
                base.Withdraw(amount);
            }
        }
    }

    internal static class Assignment
    {
        public static void Test()
        {
            var account = GetAccount();
            account.ShowBalance();
            account.Deposit(20000);
            account.Withdraw(50000);
            account.ShowBalance();
            account.IssueChequeBook();
            account.ComputeAndDepositInterest();
            account.ShowBalance();

            Console.WriteLine(account.IsBelowMinimumBalance(0)
                ? "IsBelowMinimumBalance? Balance is fine!!"
                : "IsBelowMinimumBalance? Balance is below danger level!!");
        }

        private static Account GetAccount()
        {
            Console.WriteLine("Enter Name: ");
            var customerName = Console.ReadLine();
            Console.WriteLine("Enter accountNumber: ");
            var accountNumber = Console.ReadLine();
            Console.WriteLine("Enter AccountType [(S)avings/(C)urrent]: ");
            var accountTypeText = Console.ReadLine();

            Console.WriteLine("Enter your opening balance: ");
            var balanceText = Console.ReadLine();
            if (string.IsNullOrEmpty(balanceText))
            {
                Console.WriteLine("Please enter a valid number");
                return null;
            }

            var openingBalance = int.Parse(balanceText);

            switch (accountTypeText)
            {
                case "s":
                case "S":
                    return new SavingsAccount(customerName, accountNumber, openingBalance);
                case "c":
                case "C":
                    return new CurrentAccount(customerName, accountNumber, openingBalance);
            }

            return null;
        }
    }
}
