public class ListingActivity : Activity
{   
    private List<string> _listingList = new List<string>();  
    public ListingActivity() : base()  
    {
        _title = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void RunListingActivity()
    {
        _listingList.Add("Who are people that you appreciate?");
        _listingList.Add("What are personal strengths of yours?");
        _listingList.Add("Who are people that you have helped this week?");
        _listingList.Add("When have you felt the Holy Ghost this month?");
        _listingList.Add("Who are some of your personal heroes?");

        WelcomeMessage(_title, _description);
        GetReady();
        ListingAssembler();
        EndMessage(_duration, _title);   
    }
    public void ListingAssembler()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {RandomPrompt(_listingList)} ---");
        Console.WriteLine();
        Console.Write("you may begin in:");
        Counter(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int listeditems = 0;

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            listeditems++;
        }
        Console.WriteLine($"You listed {listeditems} items!");  
    }  
}



   