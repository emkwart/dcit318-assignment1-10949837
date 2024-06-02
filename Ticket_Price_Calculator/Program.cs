using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        // Attempt to parse the input to an integer
        if (int.TryParse(input, out age))
        {
            // Calculate the ticket price based on age
            int ticketPrice = CalculateTicketPrice(age);
            Console.WriteLine($"The ticket price for age {age} is GHC{ticketPrice}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }

    static int CalculateTicketPrice(int age)
    {
        if (age <= 12 || age >= 65)
        {
            return 7; // Discounted price
        }
        else
        {
            return 10; // Regular price
        }
    }
}
