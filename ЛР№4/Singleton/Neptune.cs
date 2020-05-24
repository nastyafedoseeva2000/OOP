using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Neptune: HeavenlyBody, Planet
    {
        private static Neptune instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Neptune()
        {
            name = "Нептун";
            diameter = 50538;
            temperature = -220;
            numberOfSatellites = 8;
            mainSatellites = "Тритон";
            PeriodOfRevolutionAroundTheSun = 60152;
            RotationPeriod = 967;
    }
        public static Neptune Instance()
        {
            if (instance == null)
                instance = new Neptune();
            return instance;
        }
    }
}
