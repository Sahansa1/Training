

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Helper
{
    private List<Movie> movies = new List<Movie>();
    private List<Booking> bookings = new List<Booking>();
    private Regex numberRegex = new Regex(@"^\d+$"); 

    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }

    public void ShowMovies()
    {
        Console.WriteLine("\nAvailable Movies:");
        for (int i = 0; i < movies.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            movies[i].Display();
        }
    }

    public void BookTickets(User user)
    {
        ShowMovies();

        Console.Write("\nEnter movie number: ");
        string movieInput = Console.ReadLine();

        if (!numberRegex.IsMatch(movieInput) || !IsValidIndex(movieInput, movies.Count, out int movieIndex))
        {
            Console.WriteLine("Invalid movie selection.");
            return;
        }

        Console.Write("Enter number of tickets: ");
        string ticketInput = Console.ReadLine();

        if (!numberRegex.IsMatch(ticketInput) || !IsValidIndex(ticketInput, int.MaxValue, out int ticketCount))
        {
            Console.WriteLine("Invalid ticket number");
            return;
        }

        Movie selected = movies[movieIndex - 1];

        if (selected.BookTickets(ticketCount))
        {
            bookings.Add(new Booking(user, selected, ticketCount));
            Console.WriteLine("Booking successful!");
        }
        else
        {
            Console.WriteLine("Not enough tickets");
        }
    }

    public void ShowBookings()
    {
        if (bookings.Count == 0)
        {
            Console.WriteLine("No bookings yet");
            return;
        }

        Console.WriteLine("\nBookings:");
        foreach (var booking in bookings)
        {
            booking.Display();
        }
    }


    private bool IsValidIndex(string input, int max, out int result)
    {
        result = int.Parse(input);
        return result > 0 && result <= max;
    }
}
