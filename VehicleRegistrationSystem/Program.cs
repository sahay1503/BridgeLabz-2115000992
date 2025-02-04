using System;



class Program
{
    public static void Main()
    {
        bool exit = false; // Controls the loop, program runs until exit becomes true
        Vehicle newVehicle = null; // Initialize to avoid unassigned error

        while (!exit) // Loop runs continuously until the user chooses to exit
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to the Vehicle Registration System");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("What do you want to do?\n 1. Register a Vehicle\n 2. Display Total Registered Vehicles\n 3. Display Vehicle Details\n 4. Update Registration Fee\n 5. Exit");
            Console.WriteLine("------------------------------------------------");

            int choice = int.Parse(Console.ReadLine() ?? "");
            // Perform actions based on user's choice
            switch (choice)
            {
                case 1:
                    // Ask user for vehicle details
                    Console.WriteLine("Enter Owner Name: ");
                    string ownerName = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Vehicle Type (e.g., Car, Bike, Truck): ");
                    string vehicleType = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Vehicle Registration Number: ");
                    string registrationNumber = Console.ReadLine() ?? "";

                    // Create a new Vehicle object with user input
                    newVehicle = new Vehicle(ownerName, vehicleType, registrationNumber);

                    // Display the vehicle details
                    newVehicle.DisplayVehicleDetails();
                    break;

                case 2:
                    // Display total number of vehicles registered
                    Vehicle.DisplayTotalVehicles();
                    break;

                case 3:
                    // Display vehicle details if a vehicle has been registered
                    if (newVehicle != null)
                    {
                        Vehicle.DisplayIfVehicle(newVehicle);
                    }
                    else
                    {
                        Console.WriteLine("No vehicle has been registered yet.");
                    }
                    break;

                case 4:
                    // Update the registration fee
                    Console.WriteLine("Enter new registration fee: ");
                    double newFee = double.Parse(Console.ReadLine() ?? "");
                    Vehicle.UpdateRegistrationFee(newFee);
                    break;

                case 5:
                    // Exit the program
                    Console.WriteLine("Exiting the program...");
                    exit = true; // Set exit to true to break out of the loop
                    break;

                default:
                    // Handle incorrect menu choices
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }
}
