using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMosah
{
    public class FuelEngine : Engine
    {
        public string fuelType;
        public float currentFuelQuantity;
        public float maxFuelQuantity;

        public FuelEngine(string fuelType, float currentFuelQuantity, float maxFuelQuantity)
        {
            this.fuelType = fuelType;
            this.currentFuelQuantity = currentFuelQuantity;
            this.maxFuelQuantity = maxFuelQuantity;
        }
        public void Refueling()
        {
            this.currentFuelQuantity =maxFuelQuantity;
            Console.WriteLine("You get Fual Tank!");
        }

        public override string ToString()
        {

            return $"***FuelEngine***\nfuelType: {fuelType}\tcurrentFuelQuantity: {currentFuelQuantity}\tmaxFuelQuantity: {maxFuelQuantity}\n";
        }
    }
}
