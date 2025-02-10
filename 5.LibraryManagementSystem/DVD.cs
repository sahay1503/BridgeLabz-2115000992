namespace LibraryManagementSystem
{

    // Concrete class for DVDs
    public class DVD : LibraryItem, IReservable
    {
        private bool isAvailable; // Private field to track availability

        public DVD(string itemId, string title, string author, bool available)
            : base(itemId, title, author)
        {
            isAvailable = available;
        }

        // Override method to get loan duration (DVDs: 5 days)
        public override int GetLoanDuration()
        {
            return 5;
        }

        // Implement reservable interface methods
        public bool ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"DVD '{Title}' reserved successfully.");
                return true;
            }
            Console.WriteLine($"DVD '{Title}' is currently unavailable.");
            return false;
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }
}