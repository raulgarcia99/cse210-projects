using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        string textNumber;
        int number = 0;

        while (number !=  magicNumber)
        {
            Console.Write("What is your guess? ");
            textNumber = Console.ReadLine();
            number = int.Parse(textNumber);

                if (number == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (number > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
        }        
    }
}