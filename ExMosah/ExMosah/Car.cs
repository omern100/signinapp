using ExMosah;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExMosah
{
    public class Car : Vehicle
    {
        public string color;
        public int doors;

        public Car(string model, string iD, Engine engine, float energy, List<Wheel> wheels, string color, int doors)
    : base(model, iD, engine, energy, wheels)
        {
            this.color = color;
            this.doors = doors;
        }


    }

}
