using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Car : Vehicle
    {
        int numberOfDoors;

        public Car(int uuid, string color, int wheels, int whight, int length, int numberOfDoors)
            : base(uuid, color, wheels, whight, length, "Car")
        {
            this.numberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors
        {
            get => numberOfDoors;
            set => numberOfDoors = value;
        }

        public override string ToString()
        {
            return $"Car no: {Uuid}\n  Color={Color}\n  Wheels={Wheels}\n  Whight={Whight}\n  Length={Length}\n  NumberOfDoors={numberOfDoors}\n====================";
        }
    }
}