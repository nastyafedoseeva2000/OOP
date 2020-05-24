using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Saturn : HeavenlyBody, Planet
    {
        private static Saturn instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Saturn()
        {
            name = "Сатурн";
            diameter = 120536;
            temperature = -180;
            numberOfSatellites = 18;
            mainSatellites = "Титан";
            PeriodOfRevolutionAroundTheSun = 10753;
            RotationPeriod = 614;
        }
        public static Saturn Instance()
        {
            if (instance == null)
                instance = new Saturn();
            return instance;
        }
    }
}
