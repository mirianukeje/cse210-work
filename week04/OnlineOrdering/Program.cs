using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("1700 Market St", "Philadelphia", "PA", "USA");
        Customer customer1 = new Customer("Linda Carter", address1);
        Product product1a = new Product("Dell XPS 13", "#D100", 950, 1);
        Product product1b = new Product("Logitech MX Mouse", "#L200", 75, 2);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1a);
        order1.AddProduct(product1b);

        Console.WriteLine("\n--- Order 1 (USA Customer) ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.GetTotalCost()}");

        // Order 2: USA Customer
        Address address2 = new Address("50 Fremont St", "San Francisco", "CA", "USA");
        Customer customer2 = new Customer("Michael Chen", address2);
        Product product2a = new Product("Bose QuietComfort Earbuds", "#B300", 280, 1);
        Product product2b = new Product("Anker Power Bank", "#A400", 50, 3);
        Order order2 = new Order(customer2);
        order2.AddProduct(product2a);
        order2.AddProduct(product2b);

        Console.WriteLine("\n--- Order 2 (USA Customer) ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.GetTotalCost()}");

        // Order 3: Nigeria Customer
        Address address3 = new Address("22 Herbert Macaulay Way", "Yaba", "Lagos", "Nigeria");
        Customer customer3 = new Customer("Aisha Musa", address3);
        Product product3a = new Product("Oraimo Smart Watch", "#O500", 100, 2);
        Product product3b = new Product("Infinix Hot 12", "#I600", 180, 1);
        Order order3 = new Order(customer3);
        order3.AddProduct(product3a);
        order3.AddProduct(product3b);

        Console.WriteLine("\n--- Order 3 (Nigeria Customer) ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order3.GetTotalCost()}");
    }
}
