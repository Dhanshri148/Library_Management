using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cs_con_Traffic
{
   
    class TrafficSignal
    {
        public delegate void TrafficDelegate();

        
        public  void Signals()
        {
            Console.WriteLine("Here the signals which are used to display");
        }

        public void GreenLight()
        {
            Console.WriteLine("Green Light Signal to Go");
        }

        public void YellowLight()
        {
            Console.WriteLine("Yellow Light Signal To Ready");
        }

        public void RedLight()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }


    }
}
