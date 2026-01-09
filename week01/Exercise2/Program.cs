using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percetange grade? ");
        string textGrade = Console.ReadLine();
        int grade = int.Parse(textGrade);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.Write("Congratulations! You have passed, keep going like this!");
        }
        else
        {
            Console.Write("Sorry, you did not pass. We believe in you! You can do it better next time.");
        }
    }
}