public class Checklist : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public Checklist (string goalType, string goalName, string description, int points, int bonusPoints, int targetCount, int currentCount) : base(goalType, goalName, description, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = 0;
    }
    public Checklist ()
    {

    }
    public int GetBonus ()
    {
        return _bonusPoints;
    }

    public int GetTarget ()
    {
        return _targetCount;
    }
    public int GetCurrentCount ()
    {
        return _currentCount;
    }
    public void SetCurrentCount (int currentCount)
    {
        _currentCount = currentCount;
    }
    public void SetTarget (int targetCount)
    {
        _targetCount = targetCount;
    }

    public void SetBonus (int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public override void SetupGoalOnList ()
    {
        SetGoalType ("ChecklistGoal");
        string type = GetGoalType ();
        GoalName ();
        string name = GetName ();
        GoalDescription ();
        string description = GetDescription ();
        GoalPoints ();
        int points = GetPoints ();
        BonusPoints ();
        int bonus = GetBonus ();
        TargetCount ();
        int targetCount = GetTarget ();
        int currentCount = GetCurrentCount ();
        Checklist checklist = new Checklist (type, name, description, points, bonus, targetCount, currentCount);
        goals.Add (checklist);
    }

    public override void RecordEvent (int index)
    {
        Goal goal = goals [index];
    
        int points = goal.GetPoints ();
    
    
        if (goal is Checklist checklist)
        {
            int currentCount = checklist.GetCurrentCount ();
            currentCount += 1;
            checklist.SetCurrentCount (currentCount);
            if (checklist.GetCurrentCount () == checklist.GetTarget ())
            {
                _totalPoints += points + checklist.GetBonus ();
                Console.WriteLine ($"Congratulations! You have earned {points + checklist.GetBonus ()} points!");   
            }
            else
            {
                Console.WriteLine ($"Congratulations! You have earned {points} points!");
                _totalPoints += points;
            }     
        }
        Console.WriteLine ($"You now have {_totalPoints} points");
    }

    public void TargetCount ()
    {
        int target = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write ("What is the target count for this goal? ");
            string targetInput = Console.ReadLine ();
            validInput = int.TryParse (targetInput, out target);
            if (!validInput)
            {
                Console.WriteLine ("Invalid target count input. Please enter a valid integer value.");
            }
        }
        SetTarget (target);
    }
    public void BonusPoints ()
    {
        int bonus = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write ("What is the bonus for accomplishing it that many times? ");
            string bonusInput = Console.ReadLine ();
            validInput = int.TryParse (bonusInput, out bonus);
            if (!validInput)
            {
                Console.WriteLine("Invalid bonus point input. Please enter a valid integer value.");
            }
        }
        SetBonus(bonus);
    }
}