using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("Hello Prep5 World!");
        DisplayWelcome ();

        string user = PromptUserName ();
        int number = PromptUserNumber ();
        int squared = SquareNumber (number);

        DisplayResult (user, squared);
    }

    static void DisplayWelcome ()
    {
        Console.WriteLine ("Welcome to the program!");
    }

    static string PromptUserName ()
    {
        Console.Write ("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write ("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber (int num)
    {
        int square = num * num;
        return square;
    }

    static void DisplayResult (string name, int square)
    {
        Console.WriteLine ($"{name}, the square of your number is {square}");
    }
}