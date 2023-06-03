public class Activity
{
    protected int _duration;
    protected string _title;
    protected int _timeAnimation;
    protected string _description;
    protected int _counter;
    protected List<string> _listname;
    public void WelcomeMessage(string title, string description)
    {
        _title = title;
        _description = description;
                    
        Console.WriteLine($"Welcome to the {title} activity");
        Console.WriteLine();
        Console.WriteLine($"{description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your sessions? ");
        string strduration = Console.ReadLine();
        _duration = int.Parse(strduration);
    }
    public void EndMessage(int duration, string title)
    {
        _duration = duration;
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Animation(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {duration} seconds of the {title} Activity ");
        Animation(5);
        Console.WriteLine();
    }
    public void Counter(int counter)
    {
        _counter = counter;

        for (int i = counter; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Animation(int timeAnimation)
    {
        _timeAnimation = timeAnimation;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeAnimation);
                    
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        int i = 0;
                    
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
                        
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void GetReady()
    {
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        Animation(5);
    }

    public string RandomPrompt(List<string> listname)
    {
        _listname = listname;
        Random random = new Random();
        int index = random.Next(listname.Count);
        return $"{listname[index]}";
    }              
}
