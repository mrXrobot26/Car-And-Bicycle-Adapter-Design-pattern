using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_And_Bicycle_Adapter_Design_pattern
{
    internal class BicycleAdapter : IVhicale
    {
        private Bicycle _Bicycle;
        public BicycleAdapter(Bicycle bicycle) 
        {
            _Bicycle = bicycle;
        }
        public void accelerate()
        {
            this._Bicycle.padal();
        }

        public void soundHorn()
        {
            this._Bicycle.ringBall();
        }

        public void stop()
        {
            this._Bicycle.stop();
        }
    }
}
