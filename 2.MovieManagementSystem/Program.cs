using System;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        MovieRecord movierecord = new MovieRecord(); // Corrected class name

        while (true)
        {
            Console.WriteLine("\n--- Movie Management System ---");
            Console.WriteLine("1. Add Movie at Beginning");
            Console.WriteLine("2. Add Movie at End");
            Console.WriteLine("3. Add Movie at Specific Position");
            Console.WriteLine("4. Remove Movie by Title");
            Console.WriteLine("5. Search Movie by Director");
            Console.WriteLine("6. Search Movie by Rating");
            Console.WriteLine("7. Display All Movies (Forward)");
            Console.WriteLine("8. Display All Movies (Reverse)");
            Console.WriteLine("9. Update Movie Rating");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Title: ");
                    string title1 = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director1 = Console.ReadLine();
                    Console.Write("Enter Year: ");
                    int year1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Rating: ");
                    double rating1 = Convert.ToDouble(Console.ReadLine());
                    movierecord.AddAtBeginning(title1, director1, year1, rating1);
                    break;

                case 2:
                    Console.Write("Enter Title: ");
                    string title2 = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director2 = Console.ReadLine();
                    Console.Write("Enter Year: ");
                    int year2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Rating: ");
                    double rating2 = Convert.ToDouble(Console.ReadLine());
                    movierecord.AddAtEnd(title2, director2, year2, rating2);
                    break;

                case 3:
                    Console.Write("Enter Title: ");
                    string title3 = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director3 = Console.ReadLine();
                    Console.Write("Enter Year: ");
                    int year3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Rating: ");
                    double rating3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Position: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    movierecord.AddAtPosition(title3, director3, year3, rating3, position);
                    break;

                case 4:
                    Console.Write("Enter Movie Title to Remove: ");
                    string removeTitle = Console.ReadLine();
                    movierecord.RemoveByTitle(removeTitle);
                    break;

                case 5:
                    Console.Write("Enter Director Name: ");
                    string searchDirector = Console.ReadLine();
                    movierecord.SearchByDirector(searchDirector);
                    break;

                case 6:
                    Console.Write("Enter Rating: ");
                    double searchRating = Convert.ToDouble(Console.ReadLine());
                    movierecord.SearchByRating(searchRating);
                    break;

                case 7:
                    movierecord.DisplayForward();
                    break;

                case 8:
                    movierecord.DisplayReverse();
                    break;

                case 9:
                    Console.Write("Enter Movie Title to Update Rating: ");
                    string updateTitle = Console.ReadLine();
                    Console.Write("Enter New Rating: ");
                    double newRating = Convert.ToDouble(Console.ReadLine());
                    movierecord.UpdateRating(updateTitle, newRating);
                    break;

                case 10:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
