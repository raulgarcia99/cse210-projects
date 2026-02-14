using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity n1 = new BreathingActivity(15);
        ReflectingActivity n2 = new ReflectingActivity(52);
        ListingActivity n3 = new ListingActivity(25);
        n1.Run();
        n2.Run();
        n3.Run();
    }
}