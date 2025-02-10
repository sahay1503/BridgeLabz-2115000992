namespace LibraryManagementSystem
{
    // Abstract base class for all library items
    public abstract class LibraryItem
    {
        // Private fields to store item details
        private string itemId;
        private string title;
        private string author;

        // Public property for Item ID (read-only)
        public string ItemId
        {
            get { return itemId; }
            private set { itemId = value; }
        }

        // Public property for Title (read-only)
        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        // Public property for Author (read-only)
        public string Author
        {
            get { return author; }
            private set { author = value; }
        }

        // Constructor to initialize a library item
        public LibraryItem(string itemId, string title, string author)
        {
            this.itemId = itemId;  // Assign unique item ID
            Title = title;         // Assign title
            Author = author;       // Assign author
        }

        // Abstract method to get loan duration (implemented in derived classes)
        public abstract int GetLoanDuration();

        // Method to get item details
        public virtual void GetItemDetails()
        {
            Console.WriteLine($"ID: {ItemId}, Title: {Title}, Author: {Author}");
        }
    }

}