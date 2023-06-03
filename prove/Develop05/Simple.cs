public class Simple : Goal
{
    public Simple (string goalType, string goalName, string description, int points, string status) : base (goalType, goalName, description, points, status)
    {
        
    }
    public Simple ()
    {
        
    }
    public override void SetupGoalOnList ()
    {
        SetGoalType ("SimpleGoal");
        string type = GetGoalType ();
        GoalName ();
        string name = GetName ();
        GoalDescription ();
        string description = GetDescription ();
        GoalPoints ();
        int points = GetPoints ();
        string status = _status;
        Simple simpleGoal = new Simple (type, name, description, points, "false");
        goals.Add (simpleGoal);
    }
    public override void RecordEvent (int index)
    {
        Goal goal = goals [index];
        goal.SetStatus ("true");
        int points = goal.GetPoints ();
        _totalPoints += points ;
        Console.WriteLine ($"Congratulations! You have earned {points} points!");
        Console.WriteLine ("");
        Console.WriteLine ($"You now have {_totalPoints} points");
    }
}