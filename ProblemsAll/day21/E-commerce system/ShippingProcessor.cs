using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{
    internal class ShippingProcessor:IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("process order for shipment:");
            Console.WriteLine("================================================================");
            Console.WriteLine("Shipping Order with total:"+order.CalculateTotal().ToString("C"));
        }
        public void CancelOrder(Order order)
        { 
            Console.WriteLine("Cancelling Shipping Order:"); }
    }
}
