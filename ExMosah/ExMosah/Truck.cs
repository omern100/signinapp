using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMosah
{
    public class Truck : Vehicle
    {
        public float height;

        public Truck(string model, string iD, Engine engine, float energy, List<Wheel> wheels, float height)
            : base(model, iD, engine, energy, wheels)
        {
            this.height = height;
        }
    }
}
