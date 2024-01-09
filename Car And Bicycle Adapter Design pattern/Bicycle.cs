using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_And_Bicycle_Adapter_Design_pattern
{
    internal class Bicycle
    {
        public void padal()
        {
            Console.WriteLine("bike start moving");
        }
        public void stop()
        {
            Console.WriteLine("bike decrise speed to stop");
        }
        public void ringBall()
        {
            Console.WriteLine("Ring ring....!");
        }
    }
}
