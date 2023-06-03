public class Activity
{
    protected string _activityName;
    protected string _date;
    protected double _time;

    public Activity (string activityName, string date, double time)
    {
        _date = date;
        _time = time;
        _activityName = activityName;
    }
    public string GetActivityName ()
    {
        return _activityName;
    }
    public string GetDate ()
    {
        return _date;
    }
    public double GetTime ()
    {
        return _time;
    } 
    public virtual double GetDistance ()
    {
        return 1;
    }
    public virtual double GetSpeed ()
    {
        return 1;
    }
    public virtual double GetPace ()
    {
        return 1;
    }
    public string GetSummary ()
    {
        double speedInKph = GetSpeed ();
        double paceInMinutesPerKm = GetPace ();

        return $"{GetDate ()} {GetActivityName ()} ({GetTime ()} min) - Distance: {GetDistance ()} km, Speed: {speedInKph} kph, Pace: {paceInMinutesPerKm} min/km";
    }
}