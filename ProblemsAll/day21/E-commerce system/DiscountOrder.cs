using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//method overridding
namespace E_commerce_system
{
    internal class DiscountOrder:Order
    {
        public decimal discount = 0.1m;//10% discount
        public override decimal CalculateTotal()
        {
            return base.CalculateTotal() * (1-discount);
        }
    }
}
