public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product (string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public string GetDisplayText()
    {
        return $"{_name} {_id}, {_price}, {_quantity} units";
    }

    public double TotalPrice()
    {
        return _price * _quantity;
    }

}