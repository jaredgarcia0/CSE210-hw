using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("160 5th W S", "Rexbrg", "ID", "USA");
        Customer customer1 = new Customer("Jared Garcia", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 1200, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25, 2));

        Address address2 = new Address("233 Pappineau", "Montreal", "QC", "Canada");
        Customer customer2 = new Customer("John Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("TV", "C789", 300, 1));
        order2.AddProduct(new Product("Phone", "D012", 1000, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
