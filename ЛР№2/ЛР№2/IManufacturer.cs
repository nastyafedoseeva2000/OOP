using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_2
{
    interface IManufacturer
    {
        ComputerManufacturer Name { get; set; }
        Country Country { get; set; }
        int NumberOfEmployees { get; set; }
    }
}
