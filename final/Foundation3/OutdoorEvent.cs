public class OutdoorEvent : Event
{   
    private string _weatherForecast;
    

    public OutdoorEvent (string eventType, string eventTitle, string description, string date, string time, Address address, string weatherForecast) : base (eventType, eventTitle, description, date, time, address)
    { 
        _weatherForecast = weatherForecast;
    }
    public override string FullDetails ()
    {
        string eventDetails = base.FullDetails ();
        eventDetails = eventDetails.Replace ("Standard Event Details\n", "Full Event Details\n");
        return $"{eventDetails}\nWeather Forecast: {_weatherForecast}";
    } 
}   