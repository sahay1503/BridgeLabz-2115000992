// Program5.cs
using System;

namespace PracticePrograms.Programs
{
    class Program5
    {
        public void DistributePens()
        {
            // Total pens and number of students
            int totalPens = 14;
            int students = 3;

            // Calculate pens per student and remaining pens
            int pensPerStudent = totalPens / students;
            int remainingPens = totalPens % students;

            // Display the result
            Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}");
        }
    }
}