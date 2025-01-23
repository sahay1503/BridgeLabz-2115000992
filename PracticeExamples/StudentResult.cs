using System;

class StudentResult
{
    public static void Main()
    {
        //take marks from student
        Console.WriteLine("Enter the mark");
        int marks = Convert.ToInt32(Console.ReadLine());

        //check if student score above 50 or not if yes then passed otherwise failed
        if (marks > 50)
        {
            Console.WriteLine("Student Passed");
        }
        else
        {
            Console.WriteLine("Student Failed");
        }
    }
}