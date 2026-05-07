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
            : base(uuid, color, wheels, whight, length)
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
            return $"Motorcycle [Uuid={Uuid}, Color={Color}, Wheels={Wheels}, Whight={Whight}, Length={Length}, CubicInch={_cubicInch}]";
        }
    }
}