using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Customer
    {
        IOrder placeorder;

        public Customer(IOrder placeorder)
        {
            this.placeorder = placeorder;
        }

        public void order(string order)
        {
            Console.WriteLine("Client ordered " + order);
            placeorder.PlaceOrder(order);
        }
    }
}
