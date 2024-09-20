using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{
    internal class Order
    {
        private List<Product> products=new List<Product>();
        public void AddProduct(Product product, int quantity = 1)
        { 
        for(int i=0;i<quantity;i++)
            {
                products.Add(product);
            }
        }
        public void RemoveProduct(Product product)
        {

            products.Remove(product);
        }
     public virtual decimal CalculateTotal()
        {

            decimal total = 0;
            foreach(var product in products)
            { 
                total += product.Price;
            
            }
            return total;


        }



        public override string ToString()
        {
            return $"Order(Total:{CalculateTotal():c},{products.Count})";
        }
        public void DisplayOrder()
        {
            Console.WriteLine("Order Details:");
            foreach (var product in products)
            {
                product.DisplayProduct();
            }
            
        }
    }
}
