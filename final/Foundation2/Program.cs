using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses = new Address[2];
        Customer[] customers = new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA)
        addresses[0] = new Address("613 Mertz Rapids", "Blicktown", "Alaska", "USA");
        customers[0] = new Customer("Mr. Orrin Kiehn", addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Mini Pop Molds", "A002", 16.99f, 2));
        productsLists[0].Add(new Product("20oz 3in1 Stainless Steel Powder Coated Tumbler", "A001", 29.99f, 1));
        orders[0] = new Order(customers[0], productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("impasse Margaud Martel", "Henry", "Marie-sur-Mer", "France");
        customers[1] = new Customer("Morgan Steven", addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Ice Cream Maker", "A333", 25.99f, 3));
        productsLists[1].Add(new Product("Slush & Shake Maker Spoons", "A444", 4.99f, 1));
        productsLists[1].Add(new Product("New Zoku Quick Pop Maker Accessories 6 Sticks &amp", "A555", 23.99f, 2));
        orders[1] = new Order(customers[1], productsLists[1]);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N°{i + 1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{orders[i].GetPackingLabel()}");
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}