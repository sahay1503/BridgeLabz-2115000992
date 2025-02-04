using System; // Importing the System namespace for console input/output operations

// Main class containing the program's entry point
class Program
{
    public static void Main()
    {
        bool exit = false; // Controls the loop, program runs until exit becomes true

        while (!exit) // Loop runs continuously until the user chooses to exit
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to Bank Account System of Indian Overseas Bank");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("What do you want to do?\n 1. Create a Bank Account and display it\n 2. Total number of Bank Accounts\n 3. Exit");
            Console.WriteLine("------------------------------------------------");

            int choice = int.Parse(Console.ReadLine() ?? "");
            // Perform actions based on user's choice
            switch (choice)
            {
                case 1:
                    // Ask user for account details
                    Console.WriteLine("Enter Bank account Holder Name: ");
                    string accountHolderName = Console.ReadLine() ?? ""; // Read account holder's name

                    Console.WriteLine("Enter Bank account number: ");
                    int accountNumber = int.Parse(Console.ReadLine() ?? "");//Read account number

                    // Create a new bank account object with user input
                    BankAccount acc1 = new BankAccount(accountHolderName, accountNumber);

                    // Confirm account creation
                    Console.WriteLine("\nAccount created successfully!");
                    Console.WriteLine("Account Details:");

                    // Display account details
                    acc1.DisplayAccountDetails();
                    break;

                case 2:
                    // Show total number of bank accounts created
                    BankAccount.GetTotalAccounts();
                    break;

                case 3:
                    // Exit the program
                    Console.WriteLine("Exiting the program...");
                    exit = true; // Set exit to true to break out of the loop
                    break;

                default:
                    // Handle incorrect menu choices
                    Console.WriteLine("Wrong choice! Please enter a valid option.");
                    break;
            }
        }
    }
}
