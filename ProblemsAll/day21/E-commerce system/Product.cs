using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//Classes and Objects

namespace E_commerce_system
{
    internal class Product
    {
        private string name;
        private decimal price;
        private string category;
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        //constructor
        public Product(string name,decimal price,string category)
        {
            this.name = name;
            this.price = price;
            this.category = category;

        }
        public void UpdatePrice(decimal newprice)
        {
            price = newprice;

        }
        public override string ToString()
        {
            return $"Product(Name:{name},Price:{price},Category:{category})";
        }
        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {name}, Price: {price}, Category: {category}");
        }

    }
}
