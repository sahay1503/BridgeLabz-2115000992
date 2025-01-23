// Creating Class with name TriangleChecker indicating the purpose is to 
// check if the internal angles add to 180 

using System;

class TriangleChecker
{
    static void Main(string[] args)
    {
        // Get 3 input values for angles
        Console.WriteLine("Enter three angles of a triangle:");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        //Call the isTriangle Function
        isTriangle(x, y, z);


    }
    public static void isTriangle(int x, int y, int z)
    {
        // Find the sum of all angles
        int sumOfAngles = x + y + z;

        // Check if sum is equal to 180 and print either true or false
        Console.WriteLine("The given angles " + x + ", " + y + ", " + z + " add to " + sumOfAngles);

        if (sumOfAngles == 180)
        {
            Console.WriteLine("The given angles are internal angles of a Triangle");
        }
        else
        {
            Console.WriteLine("The given angles are not internal angles of a Triangle");
        }
    }
}
