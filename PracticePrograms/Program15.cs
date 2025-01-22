// Program15.cs
using System;

namespace PracticePrograms.Programs
{
    class Program15
    {
        public void PurchasePrice()
        {
            // Take user inputs for unit price and quantity
            Console.Write("Enter the unit price of the item: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the quantity of the item: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            // Calculate total purchase price
            double totalPrice = unitPrice * quantity;

            // Display the result
            Console.WriteLine($"The total purchase price is INR {totalPrice:F2} for a quantity of {quantity} at a unit price of INR {unitPrice:F2}.");
        }
    }
}