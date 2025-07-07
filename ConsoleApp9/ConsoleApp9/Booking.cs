public class Booking
{
    public User User { get; }
    public Movie Movie { get; }
    public int Quantity { get; }

    public Booking(User user, Movie movie, int quantity)
    {
        User = user;
        Movie = movie;
        Quantity = quantity;
    }

    public void Display()
    {
        Console.WriteLine($"{User.Name} booked {Quantity} tickets for {Movie.Title}");
    }
}
