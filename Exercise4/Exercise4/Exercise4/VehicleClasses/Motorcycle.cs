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
        public Motorcycle(int uuid, string color, int wheels, int whight, int length, int cubicInch)
            : base(uuid, color, wheels, whight, length, "Motorcycle")
        {
            this._cubicInch = cubicInch;
        }
        public int CubicInch
        {
            get => _cubicInch;
            set => _cubicInch = value;
        }

        public override string ToString()
        {
            return $"Motorcycle no: {Uuid}\n  Color={Color}\n  Wheels={Wheels}\n  Whight={Whight}\n  Length={Length}\n  CubicInch={_cubicInch}\n====================";
        }
    }
}