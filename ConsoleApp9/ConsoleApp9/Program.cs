


using System;
//using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Helper helper = new Helper();

        Console.WriteLine("Welcome to the Movie Booking System");
        Console.Write("Enter your name: ");

        string userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.Write("Enter your name to continue: ");
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Name cannot be empty. Please try again");
            }
        }

        User User1 = new User(userName);
        //Console.WriteLine($"Hello {User1.Name}! Let's book some movies");
        //User user = new User("User1");

        helper.AddMovie(new Movie("ABC", 20));
        helper.AddMovie(new Movie("XYZ", 35));

        while (true)
        {
            Console.WriteLine(@"
Movie Ticket Booking System
1 - View Movies
2 - Book Tickets
3 - View Bookings
4 - Exit");

            Console.Write("Enter choice: ");
            string input = Console.ReadLine();

            if (System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d$"))
            {
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        helper.ShowMovies();
                        break;
                    case 2:
                        helper.BookTickets(User1);
                        break;
                    case 3:
                        helper.ShowBookings();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Numbers only");
            }
        }
    }
}
