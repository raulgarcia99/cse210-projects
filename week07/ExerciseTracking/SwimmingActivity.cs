public class SwimmingActivity : Activity
{
    private int _laps;
    private double _poolLengthMeters = 50;

    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _poolLengthMeters / 1000.0;
    }

    public override double GetSpeed()
    {
        double hours = _minutes / 60.0;
        return GetDistance() / hours;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Swimming ({_minutes} min): "+
               $"Distance {GetDistance():F2} km, "+
               $"Speed {GetSpeed():F2} kph, "+
               $"Pace {GetPace():F2} min/km";
    }
}
