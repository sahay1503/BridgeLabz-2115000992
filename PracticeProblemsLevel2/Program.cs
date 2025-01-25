using System;

class Program
{
    public static void Main(string[] args)
    {
        // Input for BonusCalculation
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter salary for employee {i + 1}: ");
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter years of service for employee {i + 1}: ");
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine(new Program1().CalculateEmployeeBonus(salary, yearsOfService));

        // Input for YoungestAndTallest
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {friends[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of {friends[i]} in cm: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Call the method and display the result
        Console.WriteLine(new Program2().FindYoungestAndTallest(friends, ages, heights));


        // Input for LargestDigits
        Console.Write("Enter a number: ");
        int numberForLargest = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(new Program3().FindLargestAndSecondLargestDigit(numberForLargest));

        // Input for DynamicArrayDigits
        Console.Write("Enter a number: ");
        int numberForDynamicArray = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(new Program4().FindDigitsWithDynamicArray(numberForDynamicArray));

        // Input for ReverseDigits
        Console.Write("Enter a number: ");
        int numberForReverse = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(new Program5().ReverseNumber(numberForReverse));

        // Input for Program6 (BMI Calculation)
        Console.Write("Enter the number of persons: ");
        int numberOfPersonsForProgram6 = Convert.ToInt32(Console.ReadLine());

        double[] heightsForProgram6 = new double[numberOfPersonsForProgram6];
        double[] weightsForProgram6 = new double[numberOfPersonsForProgram6];

        for (int i = 0; i < numberOfPersonsForProgram6; i++)
        {
            Console.Write($"Enter height (in meters) for person {i + 1}: ");
            heightsForProgram6[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter weight (in kilograms) for person {i + 1}: ");
            weightsForProgram6[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine(new Program6().CalculateBMI(heightsForProgram6, weightsForProgram6));

        // Input for Program7 (BMI with 2D Array)
        Console.Write("Enter the number of persons: ");
        int numberOfPersonsForProgram7 = Convert.ToInt32(Console.ReadLine());

        double[][] personDataForProgram7 = new double[numberOfPersonsForProgram7][];
        string[] statusesForProgram7 = new string[numberOfPersonsForProgram7];

        for (int i = 0; i < numberOfPersonsForProgram7; i++)
        {
            personDataForProgram7[i] = new double[3];
            Console.Write($"Enter height (in meters) for person {i + 1}: ");
            personDataForProgram7[i][0] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter weight (in kilograms) for person {i + 1}: ");
            personDataForProgram7[i][1] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine(new Program7().CalculateBMIWith2DArray(personDataForProgram7));

        // Input for Program8 (Student Grades Calculation)
        Console.Write("Enter the number of students: ");
        int numberOfStudentsForProgram8 = Convert.ToInt32(Console.ReadLine());

        int[] physics = new int[numberOfStudentsForProgram8];
        int[] chemistry = new int[numberOfStudentsForProgram8];
        int[] maths = new int[numberOfStudentsForProgram8];

        for (int i = 0; i < numberOfStudentsForProgram8; i++)
        {
            Console.Write($"Enter marks in Physics for student {i + 1}: ");
            physics[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter marks in Chemistry for student {i + 1}: ");
            chemistry[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter marks in Maths for student {i + 1}: ");
            maths[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(new Program8().CalculateStudentGrades(physics, chemistry, maths));

        // Input taken  for Program 9(ReverseNumber)
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Program9 program9 = new Program9();
        string result = program9.ReverseNumber(number);
        Console.WriteLine(result);

        // Input for Program10 (Frequency of Digits)
        Console.Write("Enter a number: ");
        int numberForProgram10 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(new Program10().FindDigitFrequency(numberForProgram10));
    }
}
