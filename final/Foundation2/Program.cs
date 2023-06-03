using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Hello Foundation2 World!");
        Console.WriteLine ("Welcome to Tim's Fitness Store ");
        Console.WriteLine ("");

        Product product1 = new Product ("Protein Powder", "T001", 26.05, 1);
        Product product2 = new Product ("Creatine", "T002", 16.25, 1);
        Product product3 = new Product ("Wristbands", "T003", 37.5, 1);
        Product product4 = new Product ("Fitness Belt", "T004", 68.45, 1);
        Product product5 = new Product ("Ankle Supports", "T005", 43.05, 1);

        Address address1 = new Address ("210 W. 4th S.", "Rexburg", "Idaho", "USA");
        Address address2 = new Address ("No. 59, Lane 226, Tongan St.", "Taoyuan", "Taoyuan", "Taiwan");

        Customer customer1 = new Customer ("Isaac Tsao", address1);
        Customer customer2 = new Customer ("Yao Zhao", address2);

        Order order1 = new Order (customer1);
        order1.AddProduct (product2, 2);
        order1.AddProduct (product4, 1);
        order1.AddProduct (product5, 2);

        Order order2 = new Order (customer2);
        order2.AddProduct (product1, 3);
        order2.AddProduct (product3, 1);
        

        Console.WriteLine ("Order 1");
        Console.WriteLine ("Packing Label ");
        Console.WriteLine (order1.GetPackingLabel ());
        Console.WriteLine ("Shipping Label: ");
        Console.WriteLine (order1.GetShippingLabel ());
        Console.WriteLine ($"Total Price: $ {order1.CalculateTotalCost()}");
        Console.WriteLine ("");

        Console.WriteLine ("Order 2");
        Console.WriteLine ("Packing Label ");
        Console.WriteLine (order2.GetPackingLabel ());
        Console.WriteLine ("Shipping Label: ");
        Console.WriteLine (order2.GetShippingLabel ());
        Console.WriteLine ($"Total Price: $ {order2.CalculateTotalCost()}");
    }
}