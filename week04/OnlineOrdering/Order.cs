using System.Collections.Generic;

public class Order
{
    // Private member variables
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add product to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate total price including shipping
    public decimal CalculateTotalPrice()
    {
        decimal productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.CalculateTotalCost();
        }

        // Determine shipping cost based on customer location
        decimal shippingCost = _customer.IsInUSA() ? 5 : 35;

        return productTotal + shippingCost;
    }

    // Method to generate packing label
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    // Method to generate shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}