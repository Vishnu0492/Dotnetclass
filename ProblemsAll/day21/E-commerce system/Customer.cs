//Customer class derived from person

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{

    internal class Customer : Person
    {
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Customer(string name, string address, string email): base(email,name)
        {
            this.address = address;
        }
        public override string ToString()
        {
            return $"Customer(Name:{Name},Email:{Email},Address:{address})";
        }
        public void PlaceOrder()
        {
            Console.WriteLine($"{Name} has placed an order.");
        }
    }
}
