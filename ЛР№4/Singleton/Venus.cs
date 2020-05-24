using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Venus : HeavenlyBody, Planet
    {
        private static Venus instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Venus()
        {
            name = "Венера";
            diameter = 12104;
            temperature = 480;
            numberOfSatellites = 0;
            mainSatellites = "не имеет спутиников";
            PeriodOfRevolutionAroundTheSun = 224.7;
            RotationPeriod = 349920;
        }
        public static Venus Instance()
        {
            if (instance == null)
                instance = new Venus();
            return instance;
        }
    }
}