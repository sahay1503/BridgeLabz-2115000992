public class Vehicle
{
    // Static variable shared across all instances, representing the registration fee
    public static double RegistrationFee = 500.0;

    // Readonly field for RegistrationNumber (cannot be modified after initialization)
    public readonly string RegistrationNumber;

    // Instance fields to store the vehicle's owner name and vehicle type
    private string OwnerName;
    private string VehicleType;

    // Static variable to keep track of the total number of vehicles registered
    private static int totalVehicles = 0;

    // Constructor to initialize vehicle details: OwnerName, VehicleType, and RegistrationNumber
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.OwnerName = ownerName; // Assign the owner's name
        this.VehicleType = vehicleType; // Assign the vehicle type
        this.RegistrationNumber = registrationNumber; // Assign the unique registration number
        totalVehicles++; // Increment the total number of vehicles registered
    }

    // Static method to display the total number of vehicles registered
    public static void DisplayTotalVehicles()
    {
        Console.WriteLine($"Total Vehicles Registered: {totalVehicles}");
    }

    // Static method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine($"Registration Fee updated to: {RegistrationFee}");
    }

    // Method to display vehicle registration details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
        Console.WriteLine($"Registration Number: {RegistrationNumber}");
        Console.WriteLine($"Registration Fee: {RegistrationFee}");
    }

    // Method to validate whether an object is an instance of the Vehicle class
    public static void DisplayIfVehicle(object obj)
    {
        if (obj is Vehicle vehicle)
        {
            vehicle.DisplayVehicleDetails();
        }
        else
        {
            Console.WriteLine("This is not a valid Vehicle object.");
        }
    }
}