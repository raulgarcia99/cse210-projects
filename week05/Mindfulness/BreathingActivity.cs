public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base
    (
        "breathing", "breath in for some seconds and then breath out. Clear your mind when doing this exercise, so you can relax.", duration
    )
    {}
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in");
            ShowCountTime(5);
            Console.WriteLine("Breath out");
            ShowCountTime(7);
        }
        DisplayEndingMessage();
    }
}