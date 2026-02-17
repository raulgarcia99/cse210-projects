public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{_name}, {_description}, Completed: {_timesCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist goal:{_name}, {_description}, {_points}, {_timesCompleted},{_target}, {_bonus}";
    }
}
