using System;

class Program
{
    static void Main (string[] args)
    {
        int times = 0;
        string answer = "";
        int guess = -1;
        Console.WriteLine ("Hello Prep3 World!");
        
        do
        {
            Console.Write ("What is the magic number? ");
            int magic = int.Parse (Console.ReadLine ());
            times = 0;

        //Random randomGenerator = new Random();
        //int magic = randomGenerator.Next(1, 101);
            while (guess != magic)
            {
                Console.Write ("What is your guess? ");
                guess = int.Parse (Console.ReadLine());
                times++;

                if (magic > guess)
                {
                    Console.WriteLine ("Higher");
                }
                else if (magic < guess)
                {
                    Console.WriteLine ("Lower");
                }
                else
                {
                    Console.WriteLine ("You guessed it!");
                }
            }
            Console.WriteLine ($"You've guessed {times} times.");
            Console.Write ("Would you like to play again? (yes/no) ");
            answer = Console.ReadLine ();  
        } while (answer == "yes");
    }
}