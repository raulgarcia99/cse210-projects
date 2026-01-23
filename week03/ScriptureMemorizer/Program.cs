using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture x = new Scripture (
            new Reference("John", 14, 15), 
            "If you love me, keep my commandments.");

        Console.WriteLine(x.GetDisplayText());
    }
}