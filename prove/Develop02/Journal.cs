using System;

class Journal
{
    List <Entry> entries;

    public Journal ()
    {
        entries = new List <Entry> ();
    }
   
    public void DisplayEntry ()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry ();
        }

    }

    public void CreateEntry ()
    {
        PromptGenerator prompt = new PromptGenerator ();
        string userPrompt = prompt.GetRandomPrompt ();

        DateTime _date = DateTime.Now;
        string dateText = _date.ToShortDateString ();

        Console.WriteLine (userPrompt);

        Console.Write ("Response: ");
        string userResponse = Console.ReadLine ();

        Entry _entry = new Entry (dateText, userPrompt, userResponse);
        entries.Add (_entry);
    }

    public void SaveFile ()
    {

    }

    public void LoadFile ()
    {

    }
}