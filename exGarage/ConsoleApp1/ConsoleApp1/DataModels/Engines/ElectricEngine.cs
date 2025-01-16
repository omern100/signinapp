using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.DataModels.Engines
{
    public class ElectricEngine : Engine
    {
        public float m_battaryTime { get; set; }
        public float m_maxBattaryTime { get; set; }
    }
    public ElectricEngine(float i_battaryTime, float i_maxBattaryTime): base(float i_maxEnergy, float i_currentEnergy)
    {
        this.m_battaryTime = i_battaryTime;
        this.m_maxBattaryTime = i_maxBattaryTime;
        this.engine
    }
}
