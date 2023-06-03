using System;

class Program
{
    static void Main (string [] args)
    {
        Console.WriteLine ("Hello Foundation4 World!");

        List<Activity> activities = new List <Activity> ();

        activities.Add (new RunningActivity ("Running", "June 2, 2023", 20, 5));
        activities.Add (new CyclingActivity ("Cycling", "May 29, 2023", 45, 15));
        activities.Add (new SwimmingActivity ("Swimming", "August 30, 2022", 50, 4));

        foreach (Activity activity in activities)
        {
            Console.WriteLine (activity.GetSummary ());
        }
    }
}