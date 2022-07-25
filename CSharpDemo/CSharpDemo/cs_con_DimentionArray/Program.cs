using System;

namespace cs_con_DimentionArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One dimentional array:");
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            Console.WriteLine("The one dimentional array elements are:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine();


            int[,] arr1 = new int[2,3];
            arr1[0,0] = 10;
            arr1[0,1] = 11;
            arr1[0,2] = 13;
            arr1[1, 0] = 14;
            arr1[1, 1] = 15;
            arr1[1, 2] = 16;


            Console.WriteLine("The two dimentional array elements are:");
            for(int i=0; i<3;i++)
            {
                for(int j = 0;j < 3;j++)
                    {
                        Console.Write(arr1[i, j] + " ");
                    }
            }


        }
    }
}