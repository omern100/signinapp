using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExMosah
{
    public class Wheel
    {
        public string brend;
        public float currentAirPressure;
        public float maxAirPressure;


        public Wheel(string brend, float currentAirPressure, float maxAirPressure)
        {
            this.brend = brend;
            this.currentAirPressure = currentAirPressure;
            this.maxAirPressure = maxAirPressure;
        }

        public void AirFillingAir() {
            currentAirPressure = maxAirPressure;
        }

        public override string ToString()
        {

            return $"\n***wheels***\nbrend: {brend}\tcurrentAirPressure: {currentAirPressure}\tmaxAirPressure {maxAirPressure}\n";
        }


    }
}
