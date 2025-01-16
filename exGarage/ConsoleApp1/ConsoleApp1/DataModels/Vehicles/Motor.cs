using Ex01.DataModels.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.DataModels.Vehicles
{
    public class Motor : Vehicle
    {
        int licenseType;
        

        public Motor(string model, long numberID, Engine engine, float energy, float engineCapacity, int licenseType, List<Wheel> wheels) :
            base(model, numberID, engine, wheels)
        {
            this.licenseType = licenseType;
            this.m_Wheels = wheels;
           this.m_EnergyCapacity = energy;
            this.
        }

    }
}
