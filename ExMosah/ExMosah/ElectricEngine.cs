using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExMosah
{
    public class ElectricEngine : Engine
    {
        public float batteryUsageTime;
        public float batteryMaxUsageTime;

        public ElectricEngine(float batteryMaxUsageTime, float batteryUsageTime)
        {
            this.batteryMaxUsageTime = batteryMaxUsageTime;
            this.batteryUsageTime = batteryUsageTime;
        }

        public void Refueling()
        {
            this.batteryUsageTime = batteryMaxUsageTime;
            Console.WriteLine("You get Fual Tank!");
        }
        public override string ToString()
        {

            return $"\n***battery***\nbatteryUsageTime: {batteryUsageTime}\t batteryMaxUsageTime: {batteryMaxUsageTime}\n";
        }

    }

}
