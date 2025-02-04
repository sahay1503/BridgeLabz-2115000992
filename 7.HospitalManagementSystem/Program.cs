using System;
class Program
{
    public static void Main()
    {
        bool exit = false; // Controls the loop, program runs until exit becomes true
        Patient newPatient = null; // Initialize to avoid unassigned error

        while (!exit) // Loop runs continuously until the user chooses to exit
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to the Hospital Management System");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("What do you want to do?\n 1. Admit a Patient\n 2. Display Total Patients\n 3. Display Patient Details\n 4. Exit");
            Console.WriteLine("------------------------------------------------");

            int choice = int.Parse(Console.ReadLine() ?? "");
            // Perform actions based on user's choice
            switch (choice)
            {
                case 1:
                    // Ask user for patient details
                    Console.WriteLine("Enter Patient Name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Patient Age: ");
                    int age = int.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Enter Patient Ailment: ");
                    string ailment = Console.ReadLine() ?? "";

                    // Create a new Patient object with user input
                    newPatient = new Patient(name, age, ailment);

                    // Display the patient details
                    newPatient.DisplayPatientDetails();
                    break;

                case 2:
                    // Display total number of patients admitted
                    Patient.GetTotalPatients();
                    break;

                case 3:
                    // Display patient details if a patient has been admitted
                    if (newPatient != null)
                    {
                        Patient.DisplayIfPatient(newPatient);
                    }
                    else
                    {
                        Console.WriteLine("No patient has been admitted yet.");
                    }
                    break;

                case 4:
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
