public class RunningActivity : Activity
{

    private double _distance;

    public RunningActivity (string activityName, string date, double time, double distance) : base (activityName, date, time)
    {
        _distance = distance;
    }
    public override double GetDistance ()
    {
        return _distance;
    }
    public override double GetSpeed ()
    {
        return GetDistance () / GetTime () * 60;
    }
    public override double GetPace ()
    {
        return GetTime () / GetDistance ();
    }
}