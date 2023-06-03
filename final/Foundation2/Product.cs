class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    public int _quantity;

    public Product (string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName () 
    {
        return $"{_productName}";
    }
    public string GetProductId () 
    {
        return $"{_productId}";
    }

    public double CalculatePrice ()
    { 
        return _price * _quantity;
    }
}