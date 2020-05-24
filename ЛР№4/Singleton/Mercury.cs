using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Mecury : HeavenlyBody, Planet
    {
        private static Mecury instance;
        public double PeriodOfRevolutionAroundTheSun { get; set; }
        public double RotationPeriod { get; set; }
        protected Mecury()
        {
            name = "Меркурий";
            diameter = 4878;
            temperature = 350;
            numberOfSatellites = 0;
            mainSatellites = "не имеет спутиников";
            PeriodOfRevolutionAroundTheSun = 87.97;
            RotationPeriod = 83520;
        }
        public static Mecury Instance()
        {
            if (instance == null)
                instance = new Mecury();
            return instance;
        }
    }
}