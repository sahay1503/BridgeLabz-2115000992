using System;
using System.Collections.Generic;

namespace VehicleRentalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of vehicles (demonstrating polymorphism)
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("CAR123", 2000, "C12345"),
                new Bike("BIKE456", 500, "B67890"),
                new Truck("TRUCK789", 5000)
            };

            int rentalDays = 5; // Example rental period

            // Iterate over vehicles and calculate rental & insurance costs
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails();
                Console.WriteLine($"Rental Cost for {rentalDays} days: {vehicle.CalculateRentalCost(rentalDays):C}");

                // Check if the vehicle is insurable
                if (vehicle is IInsurable insurableVehicle)
                {
                    Console.WriteLine(insurableVehicle.GetInsuranceDetails());
                    Console.WriteLine($"Insurance Cost: {insurableVehicle.CalculateInsurance():C}");
                }

                Console.WriteLine(); 
            }
        }
    }
}
