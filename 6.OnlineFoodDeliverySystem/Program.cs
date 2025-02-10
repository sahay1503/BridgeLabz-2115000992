using System;
using System.Collections.Generic;

namespace OnlineFoodDeliverySystem
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of food items (demonstrating polymorphism)
            List<FoodItem> foodItems = new List<FoodItem>
            {
                new VegItem("Paneer Butter Masala", 250, 2),
                new NonVegItem("Chicken Biryani", 300, 1),
                new VegItem("Veg Burger", 150, 3),
                new NonVegItem("Fish Curry", 350, 2)
            };

            // Apply discounts dynamically
            foreach (var item in foodItems)
            {
                item.GetItemDetails();
                Console.WriteLine($"Total Price before Discount: {item.CalculateTotalPrice():C}");

                // Check if item is discountable
                if (item is IDiscountable discountableItem)
                {
                    discountableItem.ApplyDiscount(10); // Apply a 10% discount
                    Console.WriteLine(discountableItem.GetDiscountDetails());
                    Console.WriteLine($"Total Price after Discount: {item.CalculateTotalPrice():C}");
                }

                Console.WriteLine(); 
            }
        }
    }
}
