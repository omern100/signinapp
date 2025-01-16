using Ex01.DataModels;
using Ex01.DataModels.Engines;
using Ex01.DataModels.Vehicles;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel1 = new Wheel("BMW", 34, 38, 200, "F01");
            Wheel wheel2 = new Wheel("BMW", 34, 38, 200, "B01");
            List<Wheel> wheels = new List<Wheel>() { wheel1, wheel1, wheel2, wheel2 };
            Engine engine = new Engine(100, 50);
        Vehicle vehicle = new Vehicle("BMW", 12345, engine, wheels);
        }
    }
}
