using System;

class MainProgram
{
    static void Main(string[] args)
    {
        // Program 1: Leap Year Checker 1
        Console.WriteLine("### Program 1: Leap Year Check ###");
        Console.Write("Enter a year to check if it is a leap year: ");
        int year1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Leap Year Check (Method 1): " + Program1.IsLeapYear(year1));

        // Program 2: Leap Year Checker 2
        Console.WriteLine("### Program 2: Leap Year Check ###");
        Console.Write("Enter a year to check if it is a leap year: ");
        int year2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Leap Year Check (Method 2): " + Program2.IsLeapYear2(year2));
        Console.WriteLine();

        // Program 3: Grade Calculation
        Console.WriteLine("### Program 3: Grade Calculation ###");
        Console.Write("Enter marks for Physics: ");
        int physics = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks for Chemistry: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks for Maths: ");
        int maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program3.CalculateGrade(physics, chemistry, maths));
        Console.WriteLine();

        // Program 4: Prime Number Check
        Console.WriteLine("### Program 4: Prime Number Check ###");
        Console.Write("Enter a number to check if it is prime: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program4.IsPrime(number));
        Console.WriteLine();

        // Program 5: FizzBuzz using For Loop
        Console.WriteLine("### Program 5: FizzBuzz using For Loop ###");
        Console.Write("Enter a number for FizzBuzz (For Loop): ");
        int fizzBuzzFor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program5.FizzBuzz(fizzBuzzFor));
        Console.WriteLine();

        // Program 6: FizzBuzz using While Loop
        Console.WriteLine("### Program 6: FizzBuzz using While Loop ###");
        Console.Write("Enter a number for FizzBuzz (While Loop): ");
        int fizzBuzzWhile = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program6.FizzBuzz(fizzBuzzWhile));
        Console.WriteLine();

        // Program 7: BMI Calculation
        Console.WriteLine("### Program 7: BMI Calculation ###");
        Console.Write("Enter your weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your height in centimeters: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Program7.CalculateBMI(weight, height));
        Console.WriteLine();

        // Program 8: Youngest and Tallest Friend
        Console.WriteLine("### Program 8: Youngest and Tallest Among Friends ###");
        Console.Write("Enter the age of Amar: ");
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the age of Akbar: ");
        int age2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the age of Anthony: ");
        int age3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Amar in cm: ");
        int height1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Akbar in cm: ");
        int height2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Anthony in cm: ");
        int height3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program8.FindYoungestAndTallest(age1, age2, age3, height1, height2, height3));
        Console.WriteLine();

        // Program 9: Greatest Factor of a Number
        Console.WriteLine("### Program 9: Greatest Factor of a Number ###");
        Console.Write("Enter a number to find its greatest factor: ");
        int numberForFactor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program9.FindGreatestFactor(numberForFactor));
        Console.WriteLine();

        // Program 10: Power of a Number
        Console.WriteLine("### Program 10: Power of a Number ###");
        Console.Write("Enter a base number: ");
        int baseNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program10.CalculatePower(baseNumber, power));
        Console.WriteLine();

        // Program 11: Factors of a Number
        Console.WriteLine("### Program 11: Factors of a Number ###");
        Console.Write("Enter a number to find its factors: ");
        int factorsNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program11.FindFactors(factorsNumber));
        Console.WriteLine();

        // Program 12: Multiples of a Number Below 100
        Console.WriteLine("### Program 12: Multiples of a Number Below 100 ###");
        Console.Write("Enter a number to find its multiples below 100: ");
        int multiplesNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program12.FindMultiples(multiplesNumber));


    }
}