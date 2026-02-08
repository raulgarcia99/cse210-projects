using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order
        (
            new List<Product>
            {
                new Product("Shampoo Pantene", "SP301", 2.40, 2),
                new Product("Soap Extra", "SE256", 1.00, 6),
                new Product("Bleach White Magic", "BWM14", 0.35, 1)
            },
            new Customer
            (
                "Peter Longheart",
                new Address ("233 Main Street", "Oakwood", "AL")
            )
        );

        Order o2 = new Order
        (
            new List<Product>
            {
                new Product("Fan Electrix", "FE503", 15.00, 2),
                new Product("TV Samsung", "SE256", 45.00, 1),
                new Product("Iphone 10", "IP110", 100.00, 1)
            },
            new Customer
            (
                "Luna Lorenzana",
                new Address ("4ta Calle", "Oaxaca", "Mexico")
            )
        );

        List<Order> orders = new List<Order> {o1, o2};

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetDisplayText());
        }
    }
}