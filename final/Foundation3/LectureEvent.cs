public class LectureEvent : Event
{   
    private string _speaker;
    private string _capacity;

    
    public LectureEvent (string eventType, string eventTitle, string description, string date, string time, Address address, string speaker, string capacity) : base (eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string FullDetails ()
{
    string eventDetails = base.FullDetails ();
    eventDetails = eventDetails.Replace ("Standard Event Details\n", "Full Event Details\n");
    return $"{eventDetails}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
}
 
}
