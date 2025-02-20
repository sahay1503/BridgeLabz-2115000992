using System;
using System.IO;

class UserInfoToFile
{
    static void Main()
    {
        string filePath = "user_info.txt";
        bool exit = false;

        while (!exit)
        {
            try
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1 - Write user info to file");
                Console.WriteLine("2 - Read user info from file");
                Console.WriteLine("3 - Exit");
                Console.Write("Enter your choice (1, 2, or 3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteUserInfo(filePath);
                        break;
                    case "2":
                        ReadUserInfo(filePath);
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                        break;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }
    }

    static void WriteUserInfo(string filePath)
    {
        Console.WriteLine("\nEnter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        string age = Console.ReadLine();

        Console.WriteLine("Enter your favorite programming language:");
        string favoriteLanguage = Console.ReadLine();

        // Writing user input to a file using StreamWriter
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("User Information:");
            writer.WriteLine($"Name: {name}");
            writer.WriteLine($"Age: {age}");
            writer.WriteLine($"Favorite Language: {favoriteLanguage}");
        }

        Console.WriteLine($"\nUser information has been saved to {filePath}");
    }

    static void ReadUserInfo(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("\nError: No data found. Please write data first.");
            return;
        }

        Console.WriteLine("\nReading User Information from file:\n");

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
