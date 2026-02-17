using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goalPoints(goal);
        }
    }
    private int goalPoints(Goal goal)
    {
        if (goal is ChecklistGoal checklist && checklist.IsComplete())
        {
            return checklist.GetPoints() + checklist.GetBonus();
        }
        return goal.GetPoints();
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':', 2);
            string type = parts[0].Trim();
            string[] data = parts[1].Split(',');

            if (type == "Simple goal")
            {
                string name = data[0].Trim();
                string description = data[1].Trim();
                int points = int.Parse(data[2].Trim());
                bool completed = bool.Parse(data[3].Trim());

                var goal = new SimpleGoal(name, description, points);
                if (completed) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (type == "Checklist goal")
            {
                string name = data[0].Trim();
                string description = data[1].Trim();
                int points = int.Parse(data[2].Trim());
                int timesCompleted = int.Parse(data[3].Trim());
                int target = int.Parse(data[4].Trim());
                int bonus = int.Parse(data[5].Split(",")[0]);

                var goal = new ChecklistGoal(name, description, points, target, bonus);
                for (int j = 0; j < timesCompleted; j++)
                goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (type == "Eternal goal")
            {
                string name = data[0].Trim();
                string description = data[1].Trim();
                int points = int.Parse(data[2].Trim());

                _goals.Add(new EternalGoal(name, description, points));
            }
        }
    }


}
