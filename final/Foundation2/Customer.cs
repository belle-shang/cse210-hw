class Customer
{
    private string _customerName;
    public Address _address;
    

    public Customer (string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName () 
    {
        return $"{_customerName}";
    }

    public bool LiveInUsa ()
    {
        return _address.AddressInUSA();
    }
}