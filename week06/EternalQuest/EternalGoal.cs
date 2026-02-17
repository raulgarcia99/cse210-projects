public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_name}, {_description}, Always Opened";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal goal:{_name}, {_description}, {_points}";
    }
}
