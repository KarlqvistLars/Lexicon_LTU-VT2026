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

        public Airplane(int uuid, string color, int wheels, int whight, int length, int liftCapacity, decimal wingSpan)
            : base(uuid, color, wheels, whight, length, "Airplane")
        {
            this.liftCapacity = liftCapacity;
            this.wingSpan = wingSpan;
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

        public override string ToString()
        {
            return $"Airplane no: {Uuid}\n  Color={Color}\n  Wheels={Wheels}\n  Whight={Whight}\n  Length={Length}\n  LiftCapacity={liftCapacity}\n  WingSpan={wingSpan}\n====================";
        }
    }
}