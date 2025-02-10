using System;
using System.Collections.Generic;

namespace RideHailingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of vehicles (demonstrating polymorphism)
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("C123", "Amit Pratap", 15, "Govardhan Chauraha"),
                new Bike("B456", "Rashid Ali", 10, "Agra"),
                new Auto("A789", "Utkarsh Chauhan", 12, "Chaata")
            };

            double distance = 10; // Example ride distance

            // Process rides dynamically
            foreach (var vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                Console.WriteLine($"Fare for {distance} km: {vehicle.CalculateFare(distance):C}");

                // Check if vehicle has GPS functionality
                if (vehicle is IGPS gpsVehicle)
                {
                    Console.WriteLine($"Current Location: {gpsVehicle.GetCurrentLocation()}");
                    gpsVehicle.UpdateLocation("City Center");
                }

                Console.WriteLine(); 
            }
        }
    }
}