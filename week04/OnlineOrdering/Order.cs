using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double sum = 0;
        foreach (Product p in _products)
        {
            sum += p.GetTotalPrice();
        }
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return sum + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += p.GetProduct() + "\n";
        }
        return label.Trim();
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomer();
    }
}
