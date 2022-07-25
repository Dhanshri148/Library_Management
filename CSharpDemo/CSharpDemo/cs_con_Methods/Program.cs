using System;

namespace cs_con_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading");
            MethodOverloading mo = new MethodOverloading();

            Console.WriteLine("Addition of two integer=" + mo.Add(10, 20));
            Console.WriteLine("Addition of three integer=" + mo.Add(10, 20,30));
            Console.WriteLine("Addition of two float=" + mo.Add(10.99f, 20.88f));
            Console.WriteLine("Addition of two Strings=" + mo.Add("Hello","World"));
            Console.WriteLine();


            Console.WriteLine("Metod Overriding");
            A a = new A();
            Console.WriteLine("Base Class A Addition=" + a.Add(30, 40));
            Console.WriteLine();

            A b = new B();
            Console.WriteLine("Base Class B Addition=" + b.Add(40, 40));
        }
    }
}