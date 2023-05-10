using System;

class PromptGenerator
{

    List <string> prompts;

    public PromptGenerator ()
    {
        prompts = new List <string>
        {
            "What was the best part of my day? ",
            "What was the most courageous decision I made? ",
            "What was my biggest accomplishment of the day? ",
            "What am I most proud of for today? ",
            "What was the strongest emotion I felt today? ",
            "What worries me the most throughout the day? ",
            "If I had one thing I could do over today, what would it be? ",
            "How did I see the hand of the Lord in my life today? "
        };

    }

    public string GetRandomPrompt ()
    {
        return "";
    }

}