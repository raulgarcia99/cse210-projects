using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John Franks", new Address("233 Main Street", "Manhattan", "DC"));
    
        Console.WriteLine($"{customer.GetDisplayText()}");

        if (customer.LivesInUSA())
        {
            Console.WriteLine("You're from USA");
        }
        else
        {
           Console.WriteLine("You aren't from USA"); 
        }
    }
}