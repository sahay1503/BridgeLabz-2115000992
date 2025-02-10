namespace RideHailingApp
{
    // Interface for GPS functionalities
    public interface IGPS
    {
        string GetCurrentLocation(); // Method to get current location
        void UpdateLocation(string newLocation); // Method to update vehicle's location
    }
}