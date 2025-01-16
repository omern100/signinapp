using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.DataModels
{
    public class Wheel
    {
        public string m_model { get; }
        public int m_currentPSI;
        public int m_maxPSI;
        public int m_size;
        public string m_ID;

        public Wheel(string i_model, int i_currentPSI, int i_maxPSI, int i_size, string i_ID)
        {
            this.m_model = i_model;
            this.m_currentPSI = i_currentPSI;
            this.m_maxPSI = i_maxPSI;
            this.m_size = i_size;
            this.m_ID = i_ID;
        }
        public override string ToString()
        {
            return $"wheel model:{this.m_model}\n" +
                $"with currentPSI of: {this.m_currentPSI}\n" +
                $"with maxPSI of: {this.m_maxPSI}\n" +
                $"with size of: {this.m_size}\n"+
                $"with ID of: {this.m_ID}\n";

        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Wheel)) return false;
            Wheel other = (Wheel)obj;
            return this.m_ID == other.m_ID &&
                   this.m_model == other.m_model &&
                   this.m_currentPSI==other.m_currentPSI &&
                   this.m_maxPSI==other.m_maxPSI &&
                   this.m_size==other.m_size
        }
    }
}
