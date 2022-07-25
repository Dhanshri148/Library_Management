using System;

namespace cs_con_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define Structure:");
            StructDemo objStruct;
            objStruct.ID= 10;
            objStruct.name = "Dhanshri";

            Console.WriteLine("Id={0} and name={1}");
            Console.WriteLine("Id is:" + objStruct.ID + " Name is:" + objStruct.name);

            Console.WriteLine("Define Class");
            ClassDemo objClass = new ClassDemo();
            objClass.ID = 20;
            objClass.name = "Dhanshri";
            Console.WriteLine("Id is:" + objClass.ID + " Name is:" + objClass.name);
        }
    }
}