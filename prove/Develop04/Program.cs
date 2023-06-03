using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        
    }
    public static void waitSecond (int numSecond)
    {
        for (int i = 0; i <= numSecond; i++)
        {
            Thread.Sleep (1000);
        }
    }
}