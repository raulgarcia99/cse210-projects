using System.Collections.Generic;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Uknown";
        _description = "No description";
        _duration = 0;
    }

    public Activity(string name)
    {
        _name = name;
        _description = "No description";
        _duration = 10;
    }

    public Activity(string name, int duration)
    {
        _name = name;
        _description = "No description";
        _duration = duration;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine
        (
            $"Hello... Welcome to the {_name} activity. In this activity, you will\n{_description}\nIt will last {_duration} seconds, so let's begin!"
        );
        ShowSpinner(10);
        ShowCountTime(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine ("Good Job!");
        ShowSpinner(3);
        Console.WriteLine ($"You completed the {_name} activity in {_duration} seconds");
        ShowSpinner(6);
        Console.WriteLine("Program finished.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>{"|","/","-","\\","|","/","-","\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        
        while (DateTime.Now <= endTime)
        {   
            string part = spinner[i];
            Console.Write(part);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountTime(int seconds)
    {
        int numberCharacters;

        while (seconds > 0)
        {
            numberCharacters = seconds.ToString().Length;
            Console.Write(seconds);
            Thread.Sleep(1000);

            for (int i = 0; i <= numberCharacters; i++)
            {
                Console.Write("\b");
                i++;
            }
            for (int i = 0; i <= numberCharacters; i++)
            {
                Console.Write(" ");
                i++;
            }
            for (int i = 0; i <= numberCharacters; i++)
            {
                Console.Write("\b");
                i++;
            }

            seconds--;
        }
    }
}