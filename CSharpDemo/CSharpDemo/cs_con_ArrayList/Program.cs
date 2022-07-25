using System;

namespace cs_con_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Array List ");
            System.Collections.ArrayList intList = new System.Collections.ArrayList();
            intList.Add(10);
            intList.Add(20);
            intList.Add("Hello World");
            intList.Add(true);


            foreach(var val in intList)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();
           
            //Number of Items
            Console.WriteLine(intList.Count);
            Console.WriteLine();

            //Remove Element
            intList.RemoveAt(2);
            Console.WriteLine();

            //Addrange in array
            intList.AddRange(new int[] { 100, 200, 300, 400 });
           
        }
    }
}