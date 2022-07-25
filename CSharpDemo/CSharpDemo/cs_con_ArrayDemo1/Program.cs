using System;

namespace cs_con_ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");

            int[] arr = { 50, 40, 60, 70, 30 };
            Console.WriteLine("Without sorted array:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Sort(arr);
            Console.WriteLine("With sorted array:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Array  declaration
            int[] arr1 = new int[5];
            Console.Write("The  array elements are: ");
            foreach (int i in arr1)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine();


            int[] arr2 = new int[5];
            arr2[1] = 4;
            arr2[4] = 8;
            Console.Write("The array elements are: ");
            foreach (int i in arr2)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine();


            int[] arr3 = new int[3];
            arr3[0] = 10;
            arr3[1] = 20;
            arr3[2] = 30;
            Console.Write("The array elements are: ");
            foreach (int i in arr3)
            {
                Console.Write($" {i}");
            }
        }
    }
}