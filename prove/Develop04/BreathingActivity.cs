public class BreathingActivity : Activity
{   
    public BreathingActivity () : base ()  
    {
        _title = "Breathing";
        _description = "This activity will help you relax by Walking your trough breathing in and out slowly, Clear your mind and focus on your breathing.";
    }
    public void RunBreathingActivity ()
    {
        WelcomeMessage (_title, _description);
        GetReady ();
        BreathCounter ();
        Console.WriteLine ();
        EndMessage (_duration, _title);
    }
    public void BreathCounter ()
    {
        int count = ((int)Math.Floor ((double)_duration / 8));
        int count2 = 0;
        while (count2 < count)
        {
            Console.WriteLine ();
            Console.Write ("Breath in...");
            Counter (4);
            Console.WriteLine ();
            Console.Write ("Breath out...");
            Counter (4);
            Console.WriteLine ();
            count2 ++;
        }
    }   
}
