public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getter for name
    public string GetName()
    {
        return _name;
    }

    // Method to check if customer is in USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter for address
    public Address GetAddress()
    {
        return _address;
    }
}