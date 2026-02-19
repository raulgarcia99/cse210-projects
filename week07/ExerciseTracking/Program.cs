using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();


        activities.Add(new RunningActivity(DateTime.Now, 30, 5.0));
        activities.Add(new CyclingActivity(DateTime.Now, 60, 20.0));
        activities.Add(new SwimmingActivity(DateTime.Now, 45, 30));

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }

    }
}