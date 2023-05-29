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
        foreach (Entry entry in entries)
        {
            records.Add (entry.getEntryAsCSV ());
        }
        Console.WriteLine ("Name of file to save? ");
        string _fileName = Console.ReadLine ();
        File.WriteAllLines (_fileName, records);
    }

    public void LoadFile ()
    {
        Console.WriteLine ("Name of file to load? ");
        string _fileName = Console.ReadLine ();

        List <string> records = System.IO.File.ReadAllLines (_fileName).ToList ();
        foreach (string record in records)
        {
            string [] splitString = record.Split (" | ");
            Entry entry = new Entry (splitString [0], splitString [1], splitString [2]);
            entries.Add (entry);
        }

    }
}