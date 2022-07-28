using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Traffic
{
    internal class Program
    {
        public delegate void TrafficDelegate1(string msg);
        static void Main(string[] args)
        {
            TrafficSignal obj = new TrafficSignal();

            TrafficSignal.TrafficDelegate obj1 = new TrafficSignal.TrafficDelegate(obj.Signals);

            TrafficSignal.TrafficDelegate obj2 = new TrafficSignal.TrafficDelegate(obj.GreenLight);

            TrafficSignal.TrafficDelegate obj3 = new TrafficSignal.TrafficDelegate(obj.RedLight);

            TrafficSignal.TrafficDelegate obj4 = new TrafficSignal.TrafficDelegate(obj.YellowLight);

            obj.Signals();

            obj.GreenLight();

            obj.YellowLight();

            obj.RedLight();


        }
    }
}
