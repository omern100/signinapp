using Ex01.DataModels.Engines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.DataModels.Vehicles
{
    internal class Car : Vehicle
    {
        public string color {  get; set; } 
        public string Door { get; }
    }
    public Car(string Color, string Door) : base(string i_model, long i_id, Engine i_engine, List < Wheel > i_wheels) { }
}
