//inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{
    internal class Person
    {
        private string name;
        private string email; 
        public string Name
        { get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Person(string name,string email)
        {
            this.name = name;
            this.email = email;
        }
        public override string ToString()
        {
            return $"Person(Name:{name},Email:{email})";
        }
    }
}
