// Question5.cs
using System;

class Question5
{
    public void CheckSpringSeason()
    {
        // Taking user input for month and day
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the day (1-31): ");
        int day = int.Parse(Console.ReadLine());

        // Checking if it's spring season
        bool isSpring = (month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20);

        // Displaying the result
        Console.WriteLine(isSpring ? "It's a Spring Season" : "Not a Spring Season");
    }
}
