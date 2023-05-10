using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference scriptureReference = new Reference ("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture (scriptureReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths. ");
        string userInput = "";
        
        while (userInput != "quit" && scripture.HasWordsLeft () == true)
        {
            Console.Clear ();
            Console.WriteLine (scripture.GetScripture ());
            Console.WriteLine ();
            Console.WriteLine ("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine ();
            scripture.RemoveWords ();
        }

        Console.WriteLine ("Hopefully you memorized the scripture!");
    }
}