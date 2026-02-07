public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsFromUSA();
    }

    public string GetDisplayText()
    {
        return $"{_name}\n{_address.GetDisplayText()}";
    }
}