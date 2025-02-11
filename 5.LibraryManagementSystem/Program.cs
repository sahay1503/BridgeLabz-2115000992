using System;
class Program
{
    static void Main()
    {
        LibraryManagement library = new LibraryManagement();

        // Adding Hindi books by Indian authors
        library.AddAtEnd("Godan", "Munshi Premchand", "Novel", 201, true);
        library.AddAtEnd("Gunahon Ka Devta", "Dharamvir Bharati", "Romance", 202, true);
        library.AddAtBeginning("Raag Darbari", "Shrilal Shukla", "Satire", 203, false);
        library.AddAtPosition("Mujhe Chand Chahiye", "Surendra Verma", "Social", 204, true, 2);
        library.AddAtEnd("Tamas", "Bhisham Sahni", "Historical", 205, true);
        library.AddAtBeginning("Madhavi", "Bhisham Sahni", "Story", 206, true);
        library.AddAtPosition("Maila Anchal", "Phanishwar Nath 'Renu'", "Regional", 207, false, 3);

        // Displaying books in forward order
        library.DisplayForward();

        // Updating availability of a book
        library.UpdateAvailability(202, false);

        // Displaying book count
        library.CountBooks();

        // Displaying books in reverse order
        library.DisplayReverse();

        // Searching by author
        library.SearchByAuthor("Munshi Premchand");

        // Removing a book
        library.RemoveBook(203);

        // Display updated list
        library.DisplayForward();
    }
}