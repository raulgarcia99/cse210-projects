using System.Collections.Generic;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        double incrementation;

        foreach (Product product in _products)
        {
            incrementation = product.TotalPrice();
            totalCost += incrementation;
        }

        return totalCost;
    }

    private int ShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double CalculateTotalPrice()
    {
        return CalculateTotalCost() + ShippingCost();
    }
}