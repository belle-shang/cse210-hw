using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("Hello Prep2 World!");
        Console.Write ("What is your grade percentage? ");
        string answer = Console.ReadLine ();
        int percent = int.Parse (answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int plus = percent % 10;
        string sign = "";
        if (plus >= 7)
        {
            sign = "+";
        }
        else if (plus < 3)
        {
            sign = "-";
        }
        if (letter == "A" || letter =="F")
        {
            sign = "";
        }

        Console.WriteLine ($"Your grade is: {letter}{sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine ("You passed!");
        }
        else
        {
            Console.WriteLine ("You failed!");
        }
    }
}