using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicles
{
    public class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The bigrig is driving all over the place.");
        }
    }
}
