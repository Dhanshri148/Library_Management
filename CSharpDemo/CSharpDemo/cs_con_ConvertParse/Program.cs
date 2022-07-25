using System;

namespace cs_con_ConvertParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Convertion program using TryParse");
            string? name="10";
            int a;
            bool b;
            b = int.TryParse(name, out a);
            Console.WriteLine("String is a numeric representation:" + b);

        }
    }
}