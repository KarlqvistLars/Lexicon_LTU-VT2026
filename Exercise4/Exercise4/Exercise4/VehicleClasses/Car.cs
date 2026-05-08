using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Car : Vehicle
    {
        int numberOfDoors;
        int wheels;

        public Car(string uuid, string color, int whight, int length, int numberOfDoors, int wheels)
            : base(uuid, color, whight, length, "Car")
        {
            this.numberOfDoors = numberOfDoors;
            this.wheels = wheels;
        }

        public int NumberOfDoors
        {
            get => numberOfDoors;
            set => numberOfDoors = value;
        }

        public int Wheels
        {
            get => wheels;
            set => wheels = value;
        }

        public override string ToString()
        {
            return $"Bil nr: {Uuid}\n  Färg: {Color}\n  Vikt: {Whight} Kg\n  Längd: {Length} m\n  Hjul: {Wheels} st\n  Dörrar: {NumberOfDoors} st\n";
        }
    }
}