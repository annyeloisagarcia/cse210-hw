using System;

class Program

{
    static void Main(string[] args)
    {
    
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "N1001", 3.50f, 4));
        order1.AddProduct(new Product("Pen", "P2002", 1.25f, 10));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "B3003", 45.00f, 1));
        order2.AddProduct(new Product("Water Bottle", "W4004", 15.75f, 2));
        order2.AddProduct(new Product("Pencil Case", "P5005", 8.20f, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
