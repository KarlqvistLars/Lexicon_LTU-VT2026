using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Airplane
    {
        int liftCapacity;
        decimal wingSpan;

        public Airplane(int liftCapacity, decimal wingSpan)
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
    }
}