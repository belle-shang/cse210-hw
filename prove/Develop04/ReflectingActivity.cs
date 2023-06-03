public class ReflectionActivity : Activity
{   
    private List<string> _promptList = new List<string>();
    private List<string> _reflectionList = new List<string>();
    
    public ReflectionActivity() : base()  
    {
        _title = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void RunReflectionActivity()
    {
        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");
        _promptList.Add("Think of a time when you took a risk and it paid off.");

        _reflectionList.Add("Why was this experience meaningful to you?");
        _reflectionList.Add("How did this experience change your perspective on something?");
        _reflectionList.Add("How did you get started?");
        _reflectionList.Add("How did you feel when it was complete?");
        _reflectionList.Add("What made this time different than other times when you were not as successful?");
        _reflectionList.Add("What surprised you most about this experience?");
        _reflectionList.Add("What could you learn from this experience that applies to other situations?");
        _reflectionList.Add("Did this experience teach you anything new about yourself?");
        _reflectionList.Add("How can you keep this experience in mind in the future?");

        WelcomeMessage(_title, _description);
        GetReady();
        ReflectionAssembler();
        EndMessage(_duration, _title);  
    }
    public void ReflectionAssembler()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {RandomPrompt(_promptList)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("you may begin in:");
        Counter(5);
        Console.Clear();

        int count = ((int)Math.Floor((double)_duration / 15));
        int count2 = 0;
        List<string> reflectionAlreadyUsed = new List<string>();
        while (count2 < count)
        {
            string reflectionlist = RandomPrompt(_reflectionList);
             if (reflectionAlreadyUsed.Count == 9)
            {
                reflectionAlreadyUsed.Clear(); 
            } 
            while (reflectionAlreadyUsed.Contains(reflectionlist))
            {
                reflectionlist = RandomPrompt(_reflectionList);
            }  
            reflectionAlreadyUsed.Add(reflectionlist);
            Console.WriteLine($"{reflectionlist}");
            Animation(15);
            count2++;
        }
    }
}