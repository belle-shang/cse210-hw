class AllGoals
{
    private List <Goal> allGoals = new List <Goal> ();
    private int totalScore;
    public int getTotalScore ()
    {
        return totalScore;
    }
    public void DisplayPoints ()
    {
        Console.WriteLine (string.Format ("You have {0} points. \n", totalScore));
    }
    public void addGoal (Goal _goal)
    {
        allGoals.Add (_goal);
    }
    public void DisplayGoals ()
    {
        if (allGoals.Count () == 0)
        {
            Console.WriteLine ("No goals have been created or loaded.");
        }
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine (goal.ToString ());
        }
    }
    public void SaveGoals ()
    {
        if (allGoals.Count () == 0)
        {
            Console.WriteLine ("There are no goals to save.");
            return;
        }
        string fileToSave = DisplayGetGoalFile ();
        if (File.Exists (fileToSave))
        {
            LoadGoals ();
        }
        List <string> saveGoals = new List <string> ();
        saveGoals.Add (totalScore.ToString ());
        foreach (Goal goal in addGoals)
        {
            saveGoals.Add (goal.ToCSVRecord ());
        }
        SaveLoadCSV.SaveToCSV (saveGoals, fileToSave);
        Console.WriteLine ("Goals saved.");
    }
    public void LoadGoals ()
    {
        List <string> fileGoals;
        fileGoals = SaveLoadCSV.LoadFromCSV (DisplayGetGoalFile ());
        Goal goal = null;
        foreach (string goalInFile in fileGoals)
        {
            string [] goalParts = goalInFile.Split (" | ");
            int goalType = int.Parse (goalParts [0]);
            switch (goalType)
            {
                case 1:
                    goal = new Simple (goalParts [1], goalParts [2], int.Parse (goalParts [3]), bool.Parse (goalParts [4]));
                    break;
            }
            if (goal != null && allGoals.Contains (goal) == false)
            {
                allGoals.Add (goal);
            }
            Console.WriteLine ("\nGoal loaded.\n");
        }
    }
    public string DisplayGetGoalFile ()
    {
        Console.Write ("What is the filename for the goal file? ");
        return Directory.GetCurrentDirectory () + "\\files\\" + Console.ReadLine ();
    }
    public void DisplayGoalRecordEvent ()
    {
        Console.WriteLine ("The goals are: ");
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine (string.Format ("{0} {1}", allGoals.IndexOf (goal) +1, goal.getGoalName ()));
        }
        Console.Write ("Which goal did you accomplish? ");
        int recordEvent = int.Parse (Console.ReadLine ()) -1;
        allGoals [recordEvent].RecordEvent ();
        totalScore += allGoals [recordEvent].getGoalPoints ();

        Console.WriteLine (string.Format ("You now have {0} points.", totalScore.ToString ())); 
    }
}