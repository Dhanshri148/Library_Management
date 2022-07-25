using System;

namespace cs_con_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age:");
            string? ageInput = Console.ReadLine();
            int age = -1;
            if(ageInput!=null)
            {
                age = int.Parse(ageInput);
                Console.WriteLine("Age is:"+ageInput);
            }
        }
    }
}