using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook();

            Order order = new Order(cook);

            Waiter waiter = new Waiter(order);

            Customer customer1 = new Customer(waiter);

            Customer customer2 = new Customer(waiter);

            Customer customer3 = new Customer(waiter);

            customer1.order("Chicken salad, pasta, ice tea, cheese cake");

            Console.WriteLine();

            customer2.order("Vegetables & Tofu");

            Console.WriteLine();

            customer3.order("Chicken, Pork, Beef, Prawn");

            Console.WriteLine("\nList of orders");

            cook.DisplayOrders();

            Console.ReadKey();
        }
    }
}
