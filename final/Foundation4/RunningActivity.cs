public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, double distance, int time) : base(date, "Running Activity", time)
    {
        _distance = distance;
    }

    protected override double GetDistance()
    {
        return _distance;
    }
    protected override double GetSpeed()
    {
        return (_distance / GetTimeInMinutes()) * 60.0;
    }
    protected override double GetPace()
    {
        return GetTimeInMinutes() / GetDistance();
    }
}