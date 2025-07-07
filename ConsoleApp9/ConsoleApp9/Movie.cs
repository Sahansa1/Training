
using System;



public class Movie
{
    public string Title { get; set; }
    public int TicketsAvailable { get; set; }

    public Movie(string title, int ticketsAvailable)
    {
        Title = title;
        TicketsAvailable = ticketsAvailable;
    }

    public void Display()
    {
        Console.WriteLine($"{Title} - Tickets Available: {TicketsAvailable}");
    }

    public bool BookTickets(int quantity)
    {
        if (quantity <= TicketsAvailable)
        {
            TicketsAvailable -= quantity;
            return true;
        }
        return false;
    }
}
