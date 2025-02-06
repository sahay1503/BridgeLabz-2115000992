//Main Program
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Creating e-commerce platform
        ECommercePlatform myPlatform = new ECommercePlatform("ShopEasy");

        // Creating customers
        Customer customerAnkit = new Customer("Ankit");
        Customer customerAmit = new Customer("Amit");

        // Creating products
        Product laptop = new Product("Laptop", 1200.00);
        Product phone = new Product("Smartphone", 800.00);

        // Creating and placing orders
        Order order1 = new Order(1, customerAnkit);
        order1.AddProduct(laptop);
        order1.AddProduct(phone);
        customerAnkit.PlaceOrder(order1);

        Order order2 = new Order(2, customerAmit);
        order2.AddProduct(phone);
        customerAmit.PlaceOrder(order2);

        // Adding customers to the platform
        myPlatform.AddCustomer(customerAnkit);
        myPlatform.AddCustomer(customerAmit);

        // Displaying e-commerce platform data
        myPlatform.DisplayPlatform();
    }
}
