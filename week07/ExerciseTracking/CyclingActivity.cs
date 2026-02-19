public class CyclingActivity : Activity
{
    private double _speedKph;

    public CyclingActivity(DateTime date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        return _speedKph * (_minutes / 60);
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Cycling ({_minutes} min): "+
               $"Distance {GetDistance():F2} km, "+
               $"Speed {GetSpeed():F2} kph, "+
               $"Pace {GetPace():F2} min/km";
    }
}
