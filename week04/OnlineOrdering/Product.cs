public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // For the packing label
    public string GetProduct()
    {
        return $"{_name} ({_productId})";
    }

    // For total cost calculation
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}
