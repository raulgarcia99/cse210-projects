using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you accomplished an important goal for you.",
        "Think of a time when you overcame a difficult sitution."
    };

    private List<string> _questions = new List<string>
    {
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?",
        "How can you help others from this experience?",
        "Why was this experience meaningful to you?",
        "What could you do in the future to prepare for a similar situation?"
    };

    public ReflectingActivity(int duration) : base
    (
        "reflecting", "reflect on times in your life when you were strong and resilient. You will see how powerful you are.", duration
    )
    {}

    private string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            DisplayPrompt();
            ShowSpinner(3);
            DisplayQuestion();
            ShowCountTime(15);
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }
}