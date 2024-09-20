using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{
    internal interface IOrderProcessor
    {
        void ProcessOrder(Order orde);
        void CancelOrder(Order order);

    }
}
