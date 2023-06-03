public class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    public Address _address;
    
    public Event (string eventType, string eventTitle, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string StandardDetails ()
    {
        return $"Standard Event Details\n" +
            $"Title: {_eventTitle}\n" +
            $"Description: {_description}\n" +
            $"Date: {_date}\n" +
            $"Time: {_time}\n" +
            $"Address:\n{_address.GetAddressDetails ()}";
    }
    public virtual string FullDetails ()
    {
        return $"{StandardDetails ()}";
    }        
    public string ShortDescription ()
    {
        return $"Short Description\nEvent Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}";
    }              
}
