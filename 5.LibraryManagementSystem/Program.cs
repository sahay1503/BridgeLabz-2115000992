using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of library items (demonstrating polymorphism)
            List<LibraryItem> items = new List<LibraryItem>
            {
                new Book("B101", "C# Programming", "Ravi Gupta", true),
                new Magazine("M202", "Tech Monthly", "Tech Corp"),
                new DVD("D303", "Inception", "Christopher Nolan", true)
            };

            // Display details of each item
            foreach (var item in items)
            {
                item.GetItemDetails();
                Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

                // Check if item is reservable
                if (item is IReservable reservableItem)
                {
                    Console.WriteLine($"Available: {reservableItem.CheckAvailability()}");
                    reservableItem.ReserveItem(); // Attempt to reserve
                }

                Console.WriteLine(); 
            }
        }
    }
}
