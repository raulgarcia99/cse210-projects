using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture (
            new Reference("John", 14, 15), 
            "If you love me, keep my commandments.");

            bool finished = false;

        while (!finished)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' if you want to end the program");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                finished = true;
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                if (!scripture.isCompletelyHidden())
                {
                    scripture.HideRandomWords(2);
                }
                else
                {
                    finished = true;
                }
            }
        }
    }
}