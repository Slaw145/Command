using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cook: ICookAble
    {
        Queue<string> orders = new Queue<string>();

        public void AddOrder(string order)
        {
            orders.Enqueue(order);
        }

        public void CookTheMeal(string order)
        {
            AddOrder(order);
            Console.WriteLine("Cook: Cook the meal number: "+ orders.Count);
        }

        public void DisplayOrders()
        {
            foreach(string o in orders)
            {
                Console.WriteLine(o);
            }
        }
    }
}
