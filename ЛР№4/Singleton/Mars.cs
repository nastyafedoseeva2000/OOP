using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Mars : HeavenlyBody, Planet
    {
        private static Mars instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Mars()
        {
            name = "Марс";
            diameter = 6794;
            temperature = -23;
            numberOfSatellites = 2;
            mainSatellites = "Фобос, Деймос";
            PeriodOfRevolutionAroundTheSun = 687;
            RotationPeriod = 1477;
        }
        public static Mars Instance()
        {
            if (instance == null)
                instance = new Mars();
            return instance;
        }
    }
}
