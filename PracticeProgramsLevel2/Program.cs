using System;
using PracticeProblemsLevel2.Programs;
namespace PracticeProblemsLevel2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Create an instance of Program1 and call CalculateQuotientAndRemainder method
            Program1 program1 = new Program1();
            program1.CalculateQuotientAndRemainder();

            // Create an instance of Program2 and call IntOperations method
            Program2 program2 = new Program2();
            program2.IntOperations();

            // Create an instance of Program3 and call DoubleOperations method
            Program3 program3 = new Program3();
            program3.DoubleOperations();

            // Create an instance of Program4 and call CelsiusToFahrenheit method
            Program4 program4 = new Program4();
            program4.CelsiusToFahrenheit();

            // Create an instance of Program5 and call FahrenheitToCelsius method
            Program5 program5 = new Program5();
            program5.FahrenheitToCelsius();

            // Create an instance of Program6 and call CalculateTotalIncome method
            Program6 program6 = new Program6();
            program6.CalculateTotalIncome();

            // Create an instance of Program7 and call SwapNumbers method
            Program7 program7 = new Program7();
            program7.SwapNumbers();

            // Create an instance of Program8 and call SampleTrip method
            Program8 program8 = new Program8();
            program8.SampleTrip();

            // Create an instance of Program9 and call CalculateAthleteRounds method
            Program9 program9 = new Program9();
            program9.CalculateAthleteRounds();

            // Create an instance of Program10 and call DivideChocolates method
            Program10 program10 = new Program10();
            program10.DivideChocolates();

            // Create an instance of Program11 and call CalculateSimpleInterest method
            Program11 program11 = new Program11();
            program11.CalculateSimpleInterest();

            // Create an instance of Program12 and call PoundsToKilograms method
            Program12 program12 = new Program12();
            program12.PoundsToKilograms();
        }
    }
}

