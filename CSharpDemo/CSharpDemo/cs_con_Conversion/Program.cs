using System;

namespace cs_con_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long l = 40;
            int i = (int)l;

            Console.WriteLine("The number after Explicit Type Cast:{0}", i);

            int x = 10;
            long y = x;
            Console.WriteLine("The number after Implicit Type Cast:{0}", y);
        }
    }
}