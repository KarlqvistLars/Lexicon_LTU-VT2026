using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Boat
    {
        decimal maxWaterDepth;
        decimal length;
        decimal maxSpeed;
        decimal deplacement;

        public Boat(decimal maxWaterDepth, decimal length, decimal maxSpeed, decimal deplacement)
        {
            this.maxWaterDepth = maxWaterDepth;
            this.length = length;
            this.maxSpeed = maxSpeed;
            this.deplacement = deplacement;
        }
    
        public decimal MaxWaterDepth
        {
            get => maxWaterDepth;
            set => maxWaterDepth = value;
        }

        public decimal Length
        {
            get => length;
            set => length = value;
        }

        public decimal MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value;
        }

        public decimal Deplacement
        {
            get => deplacement;
            set => deplacement = value;
        }
    }
}