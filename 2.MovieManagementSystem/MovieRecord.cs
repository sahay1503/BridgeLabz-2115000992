class MovieRecord
{
    private Movie head;
    private Movie tail;
    //Add a movie at the beginning 
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = newMovie;
            tail = newMovie;
        }
        else
        {
            newMovie.Next = head;
            head.Prev = newMovie;
            head = newMovie;
        }
        Console.WriteLine("Movie is added at the beginning.");
    }
    //Add a movie at the end
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = newMovie;
            tail = newMovie;
        }
        else
        {
            tail.Next = newMovie;
            newMovie.Prev = tail;
            tail = newMovie;
        }
        Console.WriteLine("Movie is added at the end.");
    }
    //Add a movie at a specific Position
    public void AddAtPosition(string title, string director, int year, double rating, int position)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        if (position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
            temp = temp.Next;

        if (temp == null || temp.Next == null)
        {
            AddAtEnd(title, director, year, rating);
            return;
        }

        newMovie.Next = temp.Next;
        newMovie.Prev = temp;
        temp.Next.Prev = newMovie;
        temp.Next = newMovie;

        Console.WriteLine($"Movie added at position {position}.");
    }
    //Remove a movie record by Movie Title
    public void RemoveByTitle(string title)
    {
        Movie temp = head;
        if (head == null)
        {
            System.Console.WriteLine("Movie Record is empty");
        }
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }
        if (temp == head)
            head = temp.Next;
        if (temp == tail)
            tail = temp.Prev;
        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;

        Console.WriteLine($"Movie '{title}' removed.");
    }
    // Search for a movie record by Director
    public void SearchByDirector(string director)
    {
        Movie temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Director == director)
            {
                Console.WriteLine($"Found Movie: {temp.Title}, Directed by: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("No movies found for this director.");
    }

    // Search for a movie record by Rating
    public void SearchByRating(double rating)
    {
        Movie temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                Console.WriteLine($"Found Movie: {temp.Title}, Directed by: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("No movies found with this rating.");
    }

    // Display all movies Record(forward order)
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movies in the list.");
            return;
        }

        Console.WriteLine("Movie Records (Forward):");
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }

    // Display all movies (reverse order)
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No movies in the list.");
            return;
        }

        Console.WriteLine("Movie Records (Reverse):");
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Prev;
        }
    }

    // Update movie rating by Title
    public void UpdateRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine($"Updated Rating for '{title}': {newRating}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }
}