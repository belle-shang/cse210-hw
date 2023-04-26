using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 1
        Console.WriteLine ("Hello Prep1 World!");
        Console.Write ("What is your first name? ");
        string first = Console.ReadLine ();
        Console.Write ("What is your last name? ");
        string last = Console.ReadLine ();
        Console.WriteLine ("");
        Console.Write ($"Your name is {last}, {first} {last}.");
    }
}