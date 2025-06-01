public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // TODO: Add Getters/Setters as needed
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // TODO: Method to check if customer is in USA (calls Address method)
    public string GetCustomer()
    {
        return $"{_name}\n{_address.GetAddressString()}";
    }
}
