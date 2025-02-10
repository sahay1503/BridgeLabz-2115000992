namespace LibraryManagementSystem
{
    // Concrete class for Books
    public class Book : LibraryItem, IReservable
    {
        private bool isAvailable; // Private field to track availability

        public Book(string itemId, string title, string author, bool available)
            : base(itemId, title, author)
        {
            isAvailable = available; // Set initial availability
        }

        // Override method to get loan duration (Books: 14 days)
        public override int GetLoanDuration()
        {
            return 14;
        }

        // Implement reservable interface methods
        public bool ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"Book '{Title}' reserved successfully.");
                return true;
            }
            Console.WriteLine($"Book '{Title}' is currently unavailable.");
            return false;
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }
}