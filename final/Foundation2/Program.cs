using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Chocolate", "548976", 5.99,10);
        Product product2 = new Product("Flour", "038742", 3.99);
        Product product3 = new Product("Jam", "928310", 5.99, 2);
        Product product4 = new Product("Laptop", "101123", 129.99);
        Product product5 = new Product("Mug", "947510", 1.99, 6);

        Order order1 = new Order("Steve Huckleberry", "123 S Image Dr", "Denvoura", "IL", "USA");
        order1.AddToCart(product1);
        order1.AddToCart(product3);
        order1.AddToCart(product5);

        order1.DisplayPackingLabel();
        Console.WriteLine(order1.TotalPrice());
        order1.DisplayShippingLabel();

        Order order2 = new Order("Bucky Blueberry", "92 Hutsman", "Junlrest", "Wakanda", "Africa");
        order2.AddToCart(product2);
        order2.AddToCart(product4);
        order2.AddToCart(product1);

        order2.DisplayPackingLabel();
        Console.WriteLine(order2.TotalPrice());
        order2.DisplayShippingLabel();
    }
}