
// Program6.cs
using System;

namespace PracticePrograms.Programs
{
    class Program6
    {
        public void UniversityFee()
        {
            // Define fee and discount percentage
            double fee = 125000;
            double discountPercent = 10;

            // Calculate discount and final fee
            double discount = fee * (discountPercent / 100);
            double finalFee = fee - discount;

            // Display the result
            Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
        }
    }
}
