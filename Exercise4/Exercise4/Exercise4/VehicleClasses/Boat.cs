using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Boat : Vehicle
    {
        decimal maxWaterDepth;
        decimal length;
        decimal maxSpeed;
        decimal deplacement;

        public Boat(int uuid, string color, int wheels, int whight, int length, decimal maxWaterDepth, decimal boatLength, decimal maxSpeed, decimal deplacement)
            : base(uuid, color, wheels, whight, length,"Boat")
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

        public override string ToString()
        {
            return $"Boat no: {Uuid}\n  Color={Color}\n  Wheels={Wheels}\n  Whight={Whight}\n  Length={Length}\n  MaxWaterDepth={maxWaterDepth}\n  BoatLength={length}\n  MaxSpeed={maxSpeed}\n  Deplacement={deplacement}\n====================";
        }
    }
}