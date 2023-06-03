class Menu
{
    private List <string> mainMenu, createGoalMenu;
    private int select;

    public Menu ()
    {
        mainMenu = new List <string>
        {
            "Menu Options: ",
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit"
        };
        createGoalMenu = new List <string>
        {
            "The type of Goals are: ",
            "  1. Simple Goal",
            "  2. Eternal Goal",
            "  3. Checklist Goal"
        };
    }

    public int DisplayGetMainMenu ()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine (menuItem);
        }
        Console.Write ("Select a choice from the menu: ");
        return int.Parse (Console.ReadLine ());
    }

    public int DisplayGetCreateNewGoalMenu ()
    {
        foreach (string menuItem in createGoalMenu)
        {
            Console.WriteLine (menuItem);
        }
        Console.Write ("Select a choice from the menu: ");
        return int.Parse (Console.ReadLine ());
    }

    while (choice != "1" && choice != "2" && choice != "3")
    {
        Console.WriteLine ("Goals Type: ");
        foreach (string option in menuOptionList)
        {
            Console.WriteLine ($" {option}");
        }
        Console.Write ("\n Which type of goal would you like to create? ");

        choice = Console.ReadLine ();
        Console.Clear ();

        if (choice == "1")
        {
            Simple simpleGoal = new Simple ("simple");
        }
        else if (choice == "2")
        {
            Goal newGoal = new Goal ("");
            newGoal.DisplayGoals ();
        }
    }
}

