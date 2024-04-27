namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Prompting the user for input
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your initial account number:");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your initial balance amount:");
            double balance = double.Parse(Console.ReadLine());

            // Displaying the entered information
            Console.WriteLine("\nAccount Information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);

            // Further operations can be performed using these variables
            */
            Console.WriteLine("Welcome to the Basic Banking Application 🏦");
            Console.WriteLine("--------------------------------------");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your initial deposit: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());

            BankAccount account = new BankAccount(name, accountNumber, initialBalance);

            Console.WriteLine("\nAccount setup successful!\n");

            MainMenu(account);
        }


        static void MainMenu(BankAccount account)
        {
            int choice;
            do
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Deposit 💵");
                Console.WriteLine("2. Withdraw 💸");
                Console.WriteLine("3. View Balance 💰");
                Console.WriteLine("4. List Transactions 📜");
                Console.WriteLine("5. Exit 👋");
                Console.Write("Please select an option: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account.Deposit(EnterAmount());
                        break;
                    case 2:
                        account.Withdraw(EnterAmount());
                        break;
                    case 3:
                        account.ViewBalance();
                        break;
                    case 4:
                        account.ListTransactions();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using our banking application. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }

            } while (choice != 5);
        }

        static double EnterAmount()
        {
            Console.Write("Enter the amount: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
