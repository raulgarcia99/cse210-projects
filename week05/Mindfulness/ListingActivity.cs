public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "When have you felt the Holy Ghost this month?",
        "What are the activities you do the most?",
        "List the most important people in your life"
    };

    public ListingActivity(int duration) : base 
    (
        "listing", "list as many things you can based on the displayed prompt. You will realize about all good things in your life.", duration
    )
    {}

    private string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine("Think about your ideas...");
        ShowCountTime(15);
        Console.WriteLine("Type your ideas. Press enter after each idea.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                _count++;
            }
        }
        
        Console.WriteLine($"You listed {_count} ideas. Wonderful!");
        DisplayEndingMessage();

    }
}