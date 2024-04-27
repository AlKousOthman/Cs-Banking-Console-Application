using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
      
    class BankAccount
    {
        private string name;
        private int accountNumber;
        private double balance;
        private double[] transactions = new double[100];
        private int transactionIndex = 0;

        public BankAccount(string name, int accountNumber, double initialBalance)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            RecordTransaction(amount);
            Console.WriteLine($"Deposit of {amount:C} successful!");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                RecordTransaction(-amount); 
                Console.WriteLine($"Withdrawal of {amount:C} successful!");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void ViewBalance()
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        public void ListTransactions()
        {
            Console.WriteLine("Transaction History:");
            for (int i = 0; i < transactionIndex; i++)
            {
                Console.WriteLine($"Transaction {i + 1}: {transactions[i]:C}");
            }
        }

        private void RecordTransaction(double amount)
        {
            transactions[transactionIndex] = amount;
            transactionIndex++;
        }
    }
}


