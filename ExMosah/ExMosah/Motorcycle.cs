using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMosah
{
    public class Motorcycle : Vehicle
    {

        public int engineCapacity;
        public int licenseType;

        public Motorcycle(string model, string iD, Engine engine, float energy, List<Wheel> wheels, int licenseType , int engineCapacity)
            : base(model, iD, engine, energy, wheels)
            {
            this.licenseType = licenseType;
            this.engineCapacity = engineCapacity;

            }
        }
    }

