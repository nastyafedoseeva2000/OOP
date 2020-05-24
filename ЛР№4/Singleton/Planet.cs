using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    interface Planet
    {
        double PeriodOfRevolutionAroundTheSun { get; set; }
        double RotationPeriod { get; set; }
    }
}
