using System.Collections.Generic;
using System.Text;

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

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        float shippingCost = _customer.IsInUSA() ? 5.0f : 35.0f;
        return total + shippingCost;
    }

    public string GetPackingLabel()

    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (Product p in _products)
        {
            sb.AppendLine(p.GetProductInfo());
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }
}
