// Program4.cs
using System;

namespace PracticePrograms.Programs
{
    class Program4
    {
        public void CalculateProfit()
        {
            // Create variables for cost price and selling price
            int costPrice = 129;
            int sellingPrice = 191;

            // Calculate profit and profit percentage
            int profit = sellingPrice - costPrice;
            double profitPercentage = (double)profit / costPrice * 100;

            // Display the result
            Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\nThe Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%");
        }
    }
}
