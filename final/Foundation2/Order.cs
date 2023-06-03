class Order
{
    public List <Product> _products;
    
    public Customer _customer;

    

    public Order (Customer customer)
    {
        _customer = customer;
        _products = new List <Product> ();
    }

    public void AddProduct (Product product, int quantity)
    {
        _products.Add (product);
        product._quantity = quantity;
    }
    public double CalculateTotalCost ()
    {
            double totalPrice = 0;
            foreach (Product product in _products)
            {
                totalPrice += product.CalculatePrice ();
            }
            double shippingCost = _customer.LiveInUsa () ? 5 : 35;

            return totalPrice + shippingCost;
    }
    public string GetPackingLabel ()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product Name: {product.GetProductName ()}, ID: {product.GetProductId ()}\n";
        }
        return packingLabel; 
    }
     public string GetShippingLabel ()
    {
        string shippingLabel = $"Name: {_customer.GetCustomerName ()}\n";
        shippingLabel += _customer._address.GetAddressDetails ();

        return shippingLabel;
    }
    
}