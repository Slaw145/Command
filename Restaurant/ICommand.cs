using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    interface ICommand
    {
        void Execute(string order);
    }
}
