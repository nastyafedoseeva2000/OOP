using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Jupiter : HeavenlyBody, Planet
    {
        private static Jupiter instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Jupiter()
        {
            name = "Юпитер";
            diameter = 143884;
            temperature = -150;
            numberOfSatellites = 16;
            mainSatellites = "Ио, Европа, Ганимед, Каллисто";
            PeriodOfRevolutionAroundTheSun = 4329;
            RotationPeriod = 595;
        }
        public static Jupiter Instance()
        {
            if (instance == null)
                instance = new Jupiter();
            return instance;
        }
    }
}
