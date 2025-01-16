using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.DataModels.Engines
{
    internal abstract class Engine
    {
        public float m_maxEnergy { get; }
        public float m_currentEnergy { get; set;}  

        public Engine(float i_maxEnergy, float i_currentEnergy) {
            this.m_maxEnergy = i_maxEnergy;
            this.m_currentEnergy = i_currentEnergy;
        }
        public void ChargeEnergy()
        {
            this.m_currentEnergy = m_maxEnergy;
        }

    }
}
