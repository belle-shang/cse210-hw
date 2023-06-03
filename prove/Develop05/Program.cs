using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("Hello Develop05 World! ");
        Console.WriteLine ("Welcome to Goal Setter! ");
        Menu menu = new Menu ();
        AllGoals allGoals = new AllGoals ();

        int choice = 0;

        while (choice != 6)
        {
            allGoals.DisplayPoints ();
            choice = menu.DisplayGetMainMenu ();

            switch (choice)
            {
                case 1:
                    int select = menu.DisplayGetCreateNewGoalMenu ();
                    Goal goal = null;
                    switch (select)
                    {
                        case 1:
                            goal = new Simple ();
                            goal.DisplayGetGoalName ();
                            goal.DisplayGetGoalDescription ();
                            goal.DisplayGetGoalPoints ();
                            if (goal.GetType () == typeof (Goal))
                            {
                                int a = 0;
                            }
                            break;
                    }
                    if (goal != null)
                    {
                        allGoals.addGoal (goal);
                    }
                    break;
                case 2:
                    allGoals.DisplayGoals ();
                    break;
                case 3:
                    allGoals.SaveGoals ();
                    break;
                case 4:
                    allGoals.LoadGoals ();
                    break;
                case 5:
                    allGoals.DisplayGoalRecordEvent ();
                    break;
            }
        }
    }
    
}