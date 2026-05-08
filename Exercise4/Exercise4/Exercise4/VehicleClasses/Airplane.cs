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
        private int passengers;
        public Airplane(int uuid, string color, int whight, int length, int liftCapacity, decimal wingSpan, int passengers)
            : base(uuid, color, whight, length, "Airplane")
        {
            this.liftCapacity = liftCapacity;
            this.wingSpan = wingSpan;
            this.passengers = passengers;
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
        public int Passengers
        {
            get => passengers;
            set => passengers = value;
        }
        public override string ToString()
        {
            return $"Flygplan nr: {Uuid}\n  Färg: {Color}\n  Vikt: {Whight} Kg\n  Längd: {Length} m\n  Lyftkapacitet: {LiftCapacity} kg\n  Vingspann: {WingSpan} m\n  Passagerare: {Passengers} st\n";
        }
    }
}