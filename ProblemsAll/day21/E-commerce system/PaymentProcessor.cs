using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{
    internal class PaymentProcessor:IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Processing payment for Order with total:"+order.CalculateTotal().ToString("C"));
        }
        public void CancelOrder(Order order)
        { Console.WriteLine("Cancelling payment for order"); }
    }
}
