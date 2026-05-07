using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Bus : Vehicle
    {
        private int _numberOfSeats;
        
        public Bus(int uuid, string color, int wheels, int whight, int length, int numberOfSeats)
            : base(uuid, color, wheels, whight, length)
        {
            this._numberOfSeats = numberOfSeats;
        }
        
        public int NumberOfSeats
        {
            get => _numberOfSeats;
            set => _numberOfSeats = value;
        }

        public override string ToString()
        {
            return $"Bus [Uuid={Uuid}, Color={Color}, Wheels={Wheels}, Whight={Whight}, Length={Length}, NumberOfSeats={NumberOfSeats}]";
        }
    }
}