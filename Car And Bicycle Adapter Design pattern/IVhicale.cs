using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_And_Bicycle_Adapter_Design_pattern
{
    internal interface IVhicale
    {
        public void accelerate();
        public void stop();
        public void soundHorn();
    }
}
