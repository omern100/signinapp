using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ex01.DataModels.Engines;

namespace Ex01.DataModels.Vehicles
{
    public abstract class Vehicle
    {
        /// <summary>
        /// properies mix beteen member & method
        /// </summary>
        public string m_model { get; }
        public long m_id { get; }
        public float m_EnergyCapacity { get; set; }
        public List<Wheel> m_Wheels { get; set; }
        Engine m_engine { get; }

        public Vehicle(string i_model, long i_id, Engine i_engine, List<Wheel> i_wheels)
        {
            m_model = i_model;
            m_id = i_id;
           m_engine = i_engine;
            m_Wheels = i_wheels;
        }
        public override string ToString()
        {
            return $"Vehicle Modle:{m_model}\n" +
                $"with ID of: {m_id}\n" +
                $"with Engine of: {m_engine}\n" +
                $"with EnergyCapacity of:{m_EnergyCapacity}\n" +
                $"with m_Wheels of: {m_Wheels}";
        }

    }
}
