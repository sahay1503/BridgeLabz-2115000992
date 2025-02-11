class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Prev;
    public Movie Next;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}