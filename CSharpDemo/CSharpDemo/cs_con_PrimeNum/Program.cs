using System;

namespace cs_con_PrimeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int m, flag = 0;
            m = n / 2;
            for(int i=2;i<=m;i++)
            {
                if(n%i==0)
                {
                    Console.Write("Number is not prime");
                    flag = 1;
                    break;
                }
                if(flag==0)
                {
                    Console.Write("Number is prime");
                }
            }
        }
    }
}