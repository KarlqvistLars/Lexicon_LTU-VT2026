using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Boat : Vehicle
    {
        decimal maxWaterDepth;
        decimal maxSpeed;
        decimal deplacement;

        public Boat(string uuid, string color, int whight, int length, decimal maxWaterDepth, decimal maxSpeed, decimal deplacement)
            : base(uuid, color, whight, length,"Boat")
        {
            this.maxWaterDepth = maxWaterDepth;
            this.maxSpeed = maxSpeed;
            this.deplacement = deplacement;
        }
    
        public decimal MaxWaterDepth
        {
            get => maxWaterDepth;
            set => maxWaterDepth = value;
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

        public override string ToString()
        {
            return $"Båt nr: {Uuid}\n  Färg: {Color}\n  Vikt: {Whight} Kg\n  Längd: {Length} m\n  Maxdjup: {MaxWaterDepth} m\n  Maxhastighet: {MaxSpeed} kn\n  Deplacement: {Deplacement} ton\n";
        }
    }
}