using System;

namespace cs_con_SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pass by Value:");
            int i = 16;
            Console.WriteLine("Before passing square root value is:");
            Console.WriteLine("The square root is:"+Math.Sqrt(i));
            Console.WriteLine();

            PassByValue(i);
            Console.WriteLine("After passing square root value is:");
            Console.WriteLine(Math.Sqrt(i));
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Before passing square root value is:");
            Console.WriteLine("The square root is:" + Math.Sqrt(i));
            Console.WriteLine();

            Console.WriteLine("Pass By Reference");
            i = 16;
            PassByReference(ref i);
            Console.WriteLine("After passing square root value is:");
            Console.WriteLine(Math.Sqrt(i));
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Pass By Out");
            i = 16;
            PassByOut(out i);
            Console.WriteLine("After passing square root is:");
            Console.WriteLine(Math.Sqrt(i));

        }
        static void PassByValue(int x)
        {
            Console.WriteLine("After Received x value is:" + Math.Sqrt(x));
            x = 25;
            Console.WriteLine("After Calling method value is:"+Math.Sqrt(x));

        }


        static void PassByReference(ref int x)
        {
            Console.WriteLine("After Received x value is:" + Math.Sqrt(x));
            x = 25;
            Console.WriteLine("After Calling method value is:" + Math.Sqrt(x));

        }
        

        static void PassByOut(out int x)
        {
            //Console.WriteLine("After Received x value is:" + Math.Sqrt(x));
            x = 25;
           // Console.WriteLine("After Calling method value is:" + Math.Sqrt(x));
        }
    }

}