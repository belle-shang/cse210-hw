public class Goal
{
    protected string _goal;
    protected int _totalScore = 0;
    protected string _description;
    private List <Goal> _goalList = new List <Goal> ();
    protected int _goalTypeScore = 0;
    protected string _goalType;
    protected int _earnedPoints = 0;

    public Goal (int Score)
    {
        _totalScore = Score;
    } 
    public Goal (string goalType = "")
    {
        _goalType = goalType;
    }
    public Goal (string goal, string description, int earnedPoints, string goalType = "")
    {
        _goal = goal;
        _description = description;
        _earnedPoints = earnedPoints;
    }
    public virtual Goal CreateNewGoal ()
    {
        Console.Write ("What is the name of your goal? ");
        _goal = Console.ReadLine ();

        Console.Write ("Give a short description of the goal: ");
        _description = Console.ReadLine ();

        Console.Write ("How many points is this goal worth? ");
        _earnedPoints = int.Parse (Console.ReadLine ());

        Goal newGoal = new Goal (_goal, _description, _earnedPoints, GetGoalType ());

        return newGoal;
    }

    public List <Goal> AddToGoals (Goal itemToAdd)
    {
        _goalList.Add (itemToAdd);

        return _goalList;
    }
    public string GetGoal ()
    {
        return _goal;
    }
    public void DisplayGoals ()
    {
        foreach (Goal goal in _goalList)
        {

        }
    }
}

