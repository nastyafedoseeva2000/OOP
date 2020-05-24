using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Earth : HeavenlyBody, Planet
    {
        private static Earth instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Earth()
        {
            name = "Земля";
            diameter = 12756;
            temperature = 22;
            numberOfSatellites = 1;
            mainSatellites = "Луна";
            PeriodOfRevolutionAroundTheSun = 365.5;
            RotationPeriod = 1436;
        }
        public static Earth Instance()
        {
            if (instance == null)
                instance = new Earth();
            return instance;
        }
    }
}