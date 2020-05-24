using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Uranus : HeavenlyBody, Planet
    {
        private static Uranus instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Uranus()
        {
            name = "Уран";
            diameter = 51118;
            temperature = -214;
            numberOfSatellites = 15;
            mainSatellites = "Титания, Оберон";
            PeriodOfRevolutionAroundTheSun = 30664;
            RotationPeriod = 1034;
        }
        public static Uranus Instance()
        {
            if (instance == null)
                instance = new Uranus();
            return instance;
        }
    }
}
