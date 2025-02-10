namespace LibraryManagementSystem
{
    // Concrete class for Magazines
    public class Magazine : LibraryItem
    {
        public Magazine(string itemId, string title, string author)
            : base(itemId, title, author) { }

        // Override method to get loan duration (Magazines: 7 days)
        public override int GetLoanDuration()
        {
            return 7;
        }
    }
}