using System;
using ЛР_2;
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer();
            computer1.OverclockTheComputer();
            Computer computer2 = (Computer)computer1.Clone();
        }
    }
}
