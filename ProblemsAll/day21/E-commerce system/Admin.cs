using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{
    internal class Admin : Person
    {
        private int adminlevel;
        public int AdminLevel
        {
            get{return adminlevel; }

            set { adminlevel = value; }

        }
        public Admin(string Name, string Email, int adminlevel) : base(Name,Email)
        {
            this.adminlevel= adminlevel;
        }
        public override string ToString()
        {
            return $"Admin(Name:{Name},Email:{Email},Adminlevel:{adminlevel})";
        }
    }
}
