namespace LibraryManagementSystem
{
    // Interface for reservable items
    public interface IReservable
    {
        bool ReserveItem();      // Method to reserve an item
        bool CheckAvailability(); // Method to check if an item is available
    }
}