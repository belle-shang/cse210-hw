public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity (string activityName, string date, double time, double Speed) : base (activityName, date, time)
    {
        _speed = Speed;
    }
    public override double GetSpeed ()
    {
        return _speed;
    }
    public override double GetDistance ()
    {
        return GetSpeed () * (GetTime () / 60) ;
    }
    public override double GetPace ()
    {
        return GetTime () / GetDistance ();
    }
}