class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address (string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool AddressInUSA ()
    {
        return _country.Equals ("USA");
    }

    public string GetAddressDetails ()
    {
        return $"Street: {_streetAddress}\n" +
            $"City: {_city}\n" +
            $"State/Province: {_stateProvince}\n" +
            $"Country: {_country}";
    }
}