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
            : base(uuid, color, wheels, whight, length, "Bus")
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
            return $"Bus no: {Uuid}\n  Color={Color}\n  Wheels={Wheels}\n  Whight={Whight}\n  Length={Length}\n  NumberOfSeats={_numberOfSeats}\n====================";
        }
    }
}