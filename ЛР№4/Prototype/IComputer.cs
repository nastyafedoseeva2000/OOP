using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_2
{
    interface IComputer
    {
        ProcessorType ProcessorType { get; set; }
        ComputerManufacturer ComputerManufacturer { get; set; }
        OSType OperationSystemType { get; set; }
        int ProcessorCoreClock { get; set; }
        int RAMVolume { get; set; }
        List<string> InstalledPrograms { get; set; }
        List<string> UserList { get; set; }
    }
}
