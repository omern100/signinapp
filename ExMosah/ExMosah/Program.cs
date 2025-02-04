using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ExMosah
{
    public class Program
    {
        public static Vehicle CreateVehicle()
        {
            Console.WriteLine("You want to create car, truck or motorcycle?");
            string kindOfVehicle = Console.ReadLine();
            /*                         
            *     build a car                    
            *                         */
            if (kindOfVehicle == "car")
            {
                Car car;
                Console.WriteLine("Enter the car model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the car ID");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the engine type: fuel engine or electric Engine");
                string engineType = Console.ReadLine();

                Engine engine;
                if (engineType == "fuel engine")
                {
                    Console.WriteLine("Enter the car fuelType");
                    string fuelType = Console.ReadLine();

                    Console.WriteLine("Enter the currentFuelQuantity");
                    float currentFuelQuantity = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the maxFuelQuantity");
                    float maxFuelQuantity = float.Parse(Console.ReadLine());

                    engine = new FuelEngine(fuelType, currentFuelQuantity, maxFuelQuantity);
                }

                else
                {

                    Console.WriteLine("Enter the batteryUsageTime");
                    float batteryUsageTime = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the batteryMaxUsageTime");
                    float batteryMaxUsageTime = float.Parse(Console.ReadLine());

                    engine = new ElectricEngine(batteryUsageTime, batteryMaxUsageTime);
                }


                Console.WriteLine("Enter the energy");
                float energy = float.Parse(Console.ReadLine());

                List<Wheel> wheels = new List<Wheel>();
                for (int i = 0; i <= 4; i++) {

                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the wheel brand");
                    string WheelBrand = Console.ReadLine();
                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the current Air Pressure");
                    float currentAirPressure = float.Parse(Console.ReadLine());
                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the max Air Pressure");
                    float maxAirPressure = float.Parse(Console.ReadLine());
                    wheels.Add(new Wheel(WheelBrand, currentAirPressure, maxAirPressure));
                }

                Console.WriteLine("Enter the color");
                string color = Console.ReadLine();

                Console.WriteLine("Enter how match doors");
                int doors = int.Parse(Console.ReadLine());

                car = new Car(model, id, engine, energy, wheels, color, doors);

                return car;

            }
            /*                         
             *     build a truck                    
             *                         */
            if (kindOfVehicle == "truck")
            {
                Truck truck;
                Console.WriteLine("Enter the truck model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the truck ID");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the engine type: fuel engine or electric Engine");
                string engineType = Console.ReadLine();

                Engine engine;
                if (engineType == "fuel engine")
                {
                    Console.WriteLine("Enter the truck fuelType");
                    string fuelType = Console.ReadLine();

                    Console.WriteLine("Enter the currentFuelQuantity");
                    float currentFuelQuantity = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the maxFuelQuantity");
                    float maxFuelQuantity = float.Parse(Console.ReadLine());

                    engine = new FuelEngine(fuelType, currentFuelQuantity, maxFuelQuantity);
                }

                else
                {

                    Console.WriteLine("Enter the batteryUsageTime");
                    float batteryUsageTime = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the batteryMaxUsageTime");
                    float batteryMaxUsageTime = float.Parse(Console.ReadLine());

                    engine = new ElectricEngine(batteryUsageTime, batteryMaxUsageTime);
                }


                Console.WriteLine("Enter the energy");
                float energy = float.Parse(Console.ReadLine());

                List<Wheel> wheels = new List<Wheel>();
                for (int i = 0; i <= 6; i++)
                {

                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the wheel brand");
                    string WheelBrand = Console.ReadLine();
                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the current Air Pressure");
                    float currentAirPressure = float.Parse(Console.ReadLine());
                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the max Air Pressure");
                    float maxAirPressure = float.Parse(Console.ReadLine());
                    wheels.Add(new Wheel(WheelBrand, currentAirPressure, maxAirPressure));
                }

                Console.WriteLine("Enter the color");
                float height = float.Parse(Console.ReadLine());

                truck = new Truck(model, id, engine, energy, wheels, height);
                return truck;
            }
            else
            /*                         
             *     build a motorcycle                    
             *                         */

            {
                Motorcycle motorcycle;
                Console.WriteLine("Enter the motorcycle model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the motorcycle ID");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the engine type: fuel engine or electric Engine");
                string engineType = Console.ReadLine();

                Engine engine;
                if (engineType == "fuel engine")
                {
                    Console.WriteLine("Enter the truck fuelType");
                    string fuelType = Console.ReadLine();

                    Console.WriteLine("Enter the currentFuelQuantity");
                    float currentFuelQuantity = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the maxFuelQuantity");
                    float maxFuelQuantity = float.Parse(Console.ReadLine());

                    engine = new FuelEngine(fuelType, currentFuelQuantity, maxFuelQuantity);
                }

                else
                {

                    Console.WriteLine("Enter the batteryUsageTime");
                    float batteryUsageTime = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the batteryMaxUsageTime");
                    float batteryMaxUsageTime = float.Parse(Console.ReadLine());

                    engine = new ElectricEngine(batteryUsageTime, batteryMaxUsageTime);
                }


                Console.WriteLine("Enter the energy");
                float energy = float.Parse(Console.ReadLine());

                List<Wheel> wheels = new List<Wheel>();
                for (int i = 0; i <= 6; i++)
                {

                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the wheel brand");
                    string WheelBrand = Console.ReadLine();
                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the current Air Pressure");
                    float currentAirPressure = float.Parse(Console.ReadLine());
                    Console.WriteLine("wheel number" + (i + 1) + ": Enter the max Air Pressure");
                    float maxAirPressure = float.Parse(Console.ReadLine());
                    wheels.Add(new Wheel(WheelBrand, currentAirPressure, maxAirPressure));
                }

                Console.WriteLine("Enter the engineCapacity");
                int engineCapacity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the licenseType");
                int licenseType = int.Parse(Console.ReadLine());

                motorcycle = new Motorcycle(model, id, engine, energy, wheels, licenseType, engineCapacity);
                return motorcycle;
            }
        }



            static void Main(string[] args)
            {
                List<Vehicle> market = new List<Vehicle>();
                market.Add(CreateVehicle());
                market[0].showID(market);
                market[0].ChangeOrderStatos(true);

            foreach (Vehicle v in market)
            {
                Console.WriteLine(v.ToString());
            }
            }
        }
    }
