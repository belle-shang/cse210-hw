public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity (string activityName, string date, double time, int laps) : base (activityName, date, time)
    {
        _laps = laps;
    }
    public override double GetDistance ()
    {
        return _laps * 50.0 / 1000;
    }
    public override double GetSpeed ()
    {
        return (GetDistance () / GetTime ()) * 60.0;
    }
    public override double GetPace ()
    {
        return GetTime () / GetDistance ();
    }
}