using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_And_Bicycle_Adapter_Design_pattern
{
    internal class car : IVhicale
    {
        public void accelerate()
        {
            Console.WriteLine("car incrase speed");
        }
        public void stop()
        {
            Console.WriteLine("car decrase speed to speed");
        }

        public void soundHorn()
        {
            Console.WriteLine("beeb beeb beeeeebbbbbb!");
        }

    }
}
