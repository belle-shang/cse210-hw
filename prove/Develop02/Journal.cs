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

    }

    public void SaveFile ()
    {

    }

    public void LoadFile ()
    {

    }
}