public class Eternal : Goal
{
    public Eternal (string goalType, string goalName, string description, int points) : base(goalType, goalName, description, points)
    {

    }
    public Eternal ()
    {
        
    }
    public override void SetupGoalOnList ()
    {
        SetGoalType ("EternalGoal");
        string type = GetGoalType ();
        GoalName ();
        string name = GetName ();
        GoalDescription ();
        string description = GetDescription ();
        GoalPoints ();
        int points = GetPoints ();
        
        Eternal eternal = new Eternal (type, name, description, points);
        goals.Add (eternal);
    }

    public override void RecordEvent (int index)
    {
        Goal goal = goals [index];
        int points = goal.GetPoints ();
        _totalPoints += points ;
        Console.WriteLine ($"Congratulations! You have earned {points} points!");
        Console.WriteLine ("");
        Console.WriteLine ($"You now have {_totalPoints} points");
    }
}