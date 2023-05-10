using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("Hello Develop02 World!");
        Console.WriteLine ("Welcome to the Journal Program!");

        Journal journal = new Journal ();
        int choice = 0;
        
        List <string>  menu = new List <string>
        {
            "Please select one of the following choices: ",
            "1. Write ",
            "2. Display ",
            "3. Load ",
            "4. Save ",
            "5. Quit ",
            "What would you like to do? "
        };
        
        while (choice != 5)
        {
            foreach (string manuItem in menu)
            {
                Console.WriteLine (manuItem);
            }
            choice = int.Parse (Console.ReadLine ()); 
        
            switch (choice) {
                case 1:
                    PromptGenerator question = new PromptGenerator ();
                    question.GetRandomPrompt ();
                    break;
                case 2:
                
                    break;
                case 3:
                
                    break;
                case 4:
                    
                    break;
                
                default:
                    Console.WriteLine ("You typed it wrong. Please do between 1-5");
                    break;
            }
        } 
       
        
        



    }
}