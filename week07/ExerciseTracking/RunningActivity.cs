public class RunningActivity : Activity
{
    public RunningActivity(DateTime date, int minutes, double distanceKm) : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    private double _distanceKm;

    public override double GetDistance()
    {
        return _distanceKm;
    }
    public override double GetSpeed()
    {
        double hours = _minutes / 60.0;
        return GetDistance() / hours;
    }

    public override double GetPace()
    {
        return _minutes / _distanceKm;
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Running ({_minutes} min): "+
        $"Distance {GetDistance():F2} km, "+
        $"Speed {GetSpeed():F2} kph, "+
        $"Pace {GetPace():F2} min/km";
    }
}