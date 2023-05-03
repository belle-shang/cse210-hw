using System;
using System.Collections.Generic;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("Hello Prep4 World!");
        List <int> numbers = new List <int> ();
        int num = -1;
        Console.WriteLine ("Enter a list of number (type 0 to quit): ");
        
        while (num != 0)
        {
            Console.Write ("Enter number: ");
            string type = Console.ReadLine();
            num = int.Parse (type);
            
            if (num != 0)
            {
                numbers.Add (num);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine ($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine ($"The average is: {average}");

        int max = numbers [0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine ($"The max is: {max}");

        int min = numbers [0];
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }
        Console.WriteLine ($"The min of positive number is: {min}");

        int temp, i, j;
        for (i=0; i < numbers.Count; i++)
        {    // 外層迴圈控制比較回數
            for (j=0; j < numbers.Count - (i+1); j++) 
            {  // 內層迴圈控制每回比較次數            
                if (numbers [j] > numbers [j+1])
                {  // 比較鄰近兩個物件，右邊比左邊小時就互換。
                    temp = numbers [j];
                    numbers [j] = numbers [j+1];
                    numbers [j+1] = temp;
                }
            }
        }
        Console.WriteLine ("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine (number);
        }
    }
}