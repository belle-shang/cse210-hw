using System.IO; 

public class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected string _status;
    protected string _goalType;
    protected static List <Goal> goals = new List <Goal> ();

    protected static int _totalPoints;
    protected int _index;

    public Goal (string goalType, string goalName, string description, int points, string status)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _points = points;
        _status = status;
    }
     public Goal (string goalType, string goalName, string description, int points)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _points = points;  
    }
    public Goal ()
    {
        
    }
    public void setIndex (int index)
    {
        _index = index;
    }
    public void SetName (string goalName)
    {
        _goalName = goalName;
    }
    public void SetStatus (string status)
    {
        _status = status;
    }
    public void SetDescription (string description)
    {
        _description = description;
    }
    public void SetPoints (int points)
    {
        _points = points;
    }
    public string GetStatus ()
    {
        return _status;
    }
    public int GetIndex ()
    {
        return _index;
    }
    public string GetName ()
    {
        return _goalName;
    }
    public string GetDescription ()
    {
        return _description;
    }

    public int GetPoints ()
    {
        return _points;
    }
    public int GetTotalPoints ()
    {
        return _totalPoints;
    }
    public void SetGoalType (string goalType)
    {
        _goalType = goalType;
    }
    public string GetGoalType ()
    {
        return _goalType;
    }
    public void ListGoals ()
    {
        Console.WriteLine ("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals [i];
            string goalName = goal.GetName ();
            string goalDescription = goal.GetDescription ();
            string status = goal.GetStatus ();
            int currentCount = 0;
            int targetCount  = 0;
            
            if (goal is Checklist checklistGoal)
            {
                string statusSymbol = (checklistGoal.GetCurrentCount () == checklistGoal.GetTarget ()) ? "[X]" : "[ ]";
                currentCount = checklistGoal.GetCurrentCount ();
                targetCount = checklistGoal.GetTarget ();
                
                Console.WriteLine ($"{i + 1}. {statusSymbol} {goalName} ({goalDescription}) -- Currently completed: {currentCount}/{targetCount}");
            }
            else if (goal is Eternal eternalGoal)
            {
                Console.WriteLine ($"{i + 1}. [ ] {goalName} ({goalDescription})");
            }
            else
            {
                string statusSymbol = (status.ToLower() == "true") ? "[X]" : "[ ]";
                Console.WriteLine ($"{i + 1}. {statusSymbol} {goalName} ({goalDescription})");
            }
        } 
    }
    public void SaveGoals ()
    {
        Console.WriteLine ("Please enter a filename to save the goal file: ");
        string fileName = Console.ReadLine ();

        using (StreamWriter outputFile = new StreamWriter (fileName))
        {
            foreach (Goal goal in goals)
            {
                string goalType = goal.GetGoalType ();
                string goalName = goal.GetName ();
                string description = goal.GetDescription ();
                int points = goal.GetPoints ();
                string status = goal.GetStatus ();

                if (goal is Checklist checklistGoal)
                {
                    int bonusPoints = checklistGoal.GetBonus ();
                    int targetCount = checklistGoal.GetTarget ();
                    int currentCount = checklistGoal.GetCurrentCount ();

                    outputFile.WriteLine ($"{goalType}:{goalName},{description},{points},{bonusPoints},{targetCount},{currentCount}");
                }
                else if (goal is Eternal eternalGoal)
                {
                    outputFile.WriteLine ($"{goalType}:{goalName},{description},{points}");
                }
                else
                {
                    outputFile.WriteLine ($"{goalType}:{goalName},{description},{points},{status}");
                }
            }
        }
    }

    public void LoadGoals ()
    {
        Console.WriteLine ("Please enter a filename to load the goal file: ");
        string fileName = "";
        fileName = Console.ReadLine ();

        string [] lines = File.ReadAllLines (fileName);

        foreach (string line in lines)
        {
            string [] parts = line.Split (":");

            string goalType = parts [0];
            string [] goalData = parts [1].Split (",");

            string goalName = goalData [0];
            string description = goalData [1];
            int points = int.Parse (goalData [2]);

            Goal goal;
            if (goalType == "ChecklistGoal")
            {
                int bonusPoints = int.Parse (goalData [3]);
                int targetCount = int.Parse (goalData [4]);
                int currentCount = int.Parse (goalData [5]);
                goal = new Checklist (goalType, goalName, description, points, bonusPoints, targetCount, currentCount);
            }
            else if (goalType == "EternalGoal")
            {
                goal = new Eternal (goalType, goalName, description, points);
            }
            else
            {
                string status = goalData [3];
                goal = new Simple (goalType, goalName, description, points, status);
            }
            goals.Add (goal);
        }
    }
    public void DisplayRecordOption ()
    {   
        ListGoals ();
        Console.WriteLine ("Which goal did you accomplish? Enter the goal number: ");
        int goalNumber = int.Parse (Console.ReadLine ());

        if (goalNumber >= 1 && goalNumber <= goals.Count)
        {
            Goal goal = goals [goalNumber - 1]; 
            _index = goalNumber - 1;
            goal.RecordEvent (_index); 
        }
        else
        {
            Console.WriteLine ("Invalid goal number. Please enter a valid goal number.");
        }
    }
    public virtual void RecordEvent (int index)
    {

    }
    public virtual void RecordEvent ()
    {

    }
    public virtual void GoalName ()
    {
        Console.Write ("What is the name of your goal? ");
        string name = Console.ReadLine ();
        SetName (name);
    }
    public virtual void GoalDescription ()
    {
        Console.Write ("What is a short description of it? ");
        string description = Console.ReadLine ();
        SetDescription (description);
    }
    public virtual void GoalPoints ()
    {
        int points = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write ("What is the amount of points associated with this goal? ");
            string pointsInput = Console.ReadLine();
            validInput = int.TryParse (pointsInput, out points);
            if (!validInput)
            {
                Console.WriteLine ("Invalid points input. Please enter a valid integer value.");
            }
        }
        SetPoints (points);
    }
    public virtual void SetupGoalOnList ()
    {
        goals.Add (this);
    }
}