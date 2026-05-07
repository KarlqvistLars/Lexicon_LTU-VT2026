using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Bus
    {
        int numberOfSeats;
        
        public Bus(int numberOfSeats)
        {
            this.numberOfSeats = numberOfSeats;
        }
        
        public int NumberOfSeats
        {
            get => numberOfSeats;
            set => numberOfSeats = value;
        }
    }
}