using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Airplane : Vehicle
    {
        int liftCapacity;
        decimal wingSpan;
        private int wheels;

        public Airplane(int uuid, string color, int whight, int length, int liftCapacity, decimal wingSpan, int wheels)
            : base(uuid, color, whight, length, "Airplane")
        {
            this.liftCapacity = liftCapacity;
            this.wingSpan = wingSpan;
            this.wheels = wheels;
        }

        public int LiftCapacity
        {
            get => liftCapacity;
            set => liftCapacity = value;
        }

        public decimal WingSpan
        {
            get => wingSpan;
            set => wingSpan = value;
        }
        public int Wheels
        {
            get => wheels;
            set => wheels = value;
        }

        public override string ToString()
        {
            return $"Flygplan nr: {Uuid}\n  Färg: {Color}\n  Hjul: {Wheels} st\n  Vikt: {Whight} Kg\n  Längd: {Length} m\n  Lyftkapacitet: {LiftCapacity} kg\n  Vingspann: {WingSpan} m\n";
        }
    }
}