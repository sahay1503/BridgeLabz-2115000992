using System;

class PassOrFail
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.Error.WriteLine("Invalid grade.");
            Environment.Exit(0);
        }

        if (grade >= 50)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed.");
        }
    }
}
