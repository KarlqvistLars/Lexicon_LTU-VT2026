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
            : base(uuid, color, wheels, whight, length)
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
            return $"Airplane [Uuid={Uuid}, Color={Color}, Wheels={Wheels}, Whight={Whight}, Length={Length}, LiftCapacity={LiftCapacity}, WingSpan={WingSpan}]";
        }
    }
}