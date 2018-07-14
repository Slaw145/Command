using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Waiter: IOrder
    {
        private ICommand Icommand;

        public Waiter(ICommand Icommand)
        {
            this.Icommand = Icommand;
        }

        public void PlaceOrder(string order)
        {
            Console.WriteLine("Waiter: Send this to a cook");
            Icommand.Execute(order);
        }
    }
}
