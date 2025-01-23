using System;

class Program
{
    static void Main(string[] args)
    {
        //Program 1: Armstrong Number Check
        Console.WriteLine("### Program1: Armstrong Number Checker ###");
        Console.Write("Enter a number: ");
        int armstrongNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program1.IsArmstrong(armstrongNumber));
        Console.WriteLine();

        //Program 2 : Digit Counter
        Console.WriteLine("### Program2: Digit Counter ###");
        Console.Write("Enter a number: ");
        int digitCountNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program2.CountDigits(digitCountNumber));
        Console.WriteLine();

        //Program 3 : Harshad Number Check
        Console.WriteLine("### Program3: Harshad Number Checker ###");
        Console.Write("Enter a number: ");
        int harshadNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program3.IsHarshad(harshadNumber));
        Console.WriteLine();

        //Program 4 : Abundant Number Check
        Console.WriteLine("### Program4: Abundant Number Checker ###");
        Console.Write("Enter a number: ");
        int abundantNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program4.IsAbundant(abundantNumber));
        Console.WriteLine();

        //Program 5 : Day of the Week Calculator
        Console.WriteLine("### Program5: Day of the Week Calculator ###");
        Console.Write("Enter the day: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program5.GetDayOfWeek(day, month, year));
        Console.WriteLine();

        // Program 6: Calculator
        Console.WriteLine("### Program6: Calculator ###");
        Console.Write("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the operator (+, -, *, /): ");
        string op = Console.ReadLine();
        Console.WriteLine(Program6.PerformOperation(first, second, op));

    }
}
