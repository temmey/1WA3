using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1WA2
{
    internal class Car : Vehicle
    {
        public Car(string VehicleDesc, int fuelCap, double fuel, double fuelConsume) : base(VehicleDesc, fuelCap, fuel, fuelConsume)
        {
        }
    }
}
