using RasterEdge.Imaging.Basic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Motorcycle : Vehicle
    {
        private int _cubicInch;
        private int _wheels = 2;
        public Motorcycle(int uuid, string color, int wheels, int whight, int length, int cubicInch)
            : base(uuid, color, whight, length, "Motorcycle")
        {
            this._cubicInch = cubicInch;
            this._wheels = wheels;
        }
        public int CubicInch
        {
            get => _cubicInch;
            set => _cubicInch = value;
        }        
        public int Wheels
        {
            get => _wheels;
            set => _wheels = value;
        }

        public override string ToString()
        {
            return $"Motorcykel nr: {Uuid}\n  Färg: {Color}\n  Hjul: {Wheels} st\n  Vikt: {Whight} Kg\n  Längd: {Length} m\n  Kubik: {CubicInch} cc\n";
        }
    }
}