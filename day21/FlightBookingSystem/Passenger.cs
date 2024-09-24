﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem
{
    internal class Passenger//Passenger details
    {
        public int PassengerId { get; set; }
        public string Name { get; set; }

        public Passenger(int passengerId, string name)
        {
            PassengerId = passengerId;
            Name = name;
        }
    }
}
