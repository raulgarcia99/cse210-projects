public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string completed;
        if (_isComplete)
        {
            completed = "Completed";
        }
        else
        {
            completed = "Not completed";
        }
        return $"{_name}, {_description}, {completed}";
    }

      public override string GetStringRepresentation()
    {
        return $"Simple goal: {_name}, {_description}, {_points}, {_isComplete}";
    }
}