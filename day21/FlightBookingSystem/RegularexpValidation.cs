using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Regular expression Validation
namespace FlightBookingSystem
{
    internal class RegularexpValidation
    {
        public bool ValidateFlightNumber(string flightNumber)
        {
            return Regex.IsMatch(flightNumber, @"^FL\d{4}$");
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\+?\d{10,15}$");
        }
    }
}
