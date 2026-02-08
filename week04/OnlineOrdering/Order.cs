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

    private double CalculateProductCost()
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

    public double CalculateTotalCost()
    {
        return CalculateProductCost() + ShippingCost();
    }

    public string CreatePackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetDisplayText()}\n";
        }
        return packingLabel;
    }

    public string CreateShippingLabel()
    {
        return _customer.GetDisplayText();
    }

    public string GetDisplayText()
    {
        string displayText= "";

        displayText += $"The final cost will be ${CalculateTotalCost():F2}\n\n";
        
        displayText += $"{CreatePackingLabel()}\n{CreateShippingLabel()}\n";

        displayText += "-----------------------------------------\n";

        return displayText;
    }
}