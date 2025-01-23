using System;

// Creating a class to check if a number is prime
class Program4
{
    // Function to check if a number is prime
    public static string IsPrime(int number)
    {
        if (number <= 1)
        {
            return number + " is not a prime number.";
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime ? number + " is a prime number." : number + " is not a prime number.";
    }
}