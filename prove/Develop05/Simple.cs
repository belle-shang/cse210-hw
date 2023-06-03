public class Simple : Goal
{
    private const int goalType = 1;
    private bool goalComplete;
    public Simple ()
    {

    }
    public Simple (string _goalName, string _goalDescription, int _points, bool _goalComplete) : base (_goalName, _goalDescription, _points)
    {
        _goalComplete = goalComplete;
    }
   public override string ToCSVRecord ()
   {
        return string.Format ("{0}|{1}|{2}|{3}|{4}", goalType, getGoalName (), getGoalDescription (), getGoalPoints (), goalComplete);
   }
}