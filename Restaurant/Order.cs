using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Order: ICommand
    {
        private ICookAble Icookcble;

        public Order(ICookAble Icookcble)
        {
            this.Icookcble = Icookcble;
        }

        public void Execute(string order)
        {
            Icookcble.CookTheMeal(order);
        }
    }
}
