// Program9.cs
using System;

namespace PracticePrograms.Programs
{
    class Program9
    {
        public void DiscountWithInput()
        {
            // Take user input for fee and discount percentage
            Console.Write("Enter the student fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the discount percentage: ");
            double discountPercent = Convert.ToDouble(Console.ReadLine());

            // Calculate discount and final fee
            double discount = fee * (discountPercent / 100);
            double finalFee = fee - discount;

            // Display the result
            Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
        }
    }
}