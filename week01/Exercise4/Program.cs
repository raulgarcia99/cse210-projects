using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        string textNumber;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            textNumber = Console.ReadLine();
            number = int.Parse(textNumber);

            numbers.Add(number);
        } while (number != 0);

        int sum = 0;
        float average;
        int max = 0;

        foreach (int item in numbers)
        {
            sum += item;

            if (item > max)
            {
                max = item;
            }
        }

        average = (float)sum/(numbers.Count-1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}