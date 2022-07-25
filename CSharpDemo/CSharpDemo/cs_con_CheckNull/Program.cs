using System;

namespace cs_con_CheckNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string? name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string? ageInput = Console.ReadLine();
            int age = -1;
            if (!string.IsNullOrEmpty(ageInput))
            {
                age = int.Parse(ageInput);
                
            }
            bool b1 = string.IsNullOrEmpty(ageInput);
            Console.WriteLine(b1);

            Console.WriteLine("Hi " + name + ". You are " + age.ToString() + " years old!");
            Console.WriteLine("Length of string is:" + name.Length);
            Console.WriteLine("Hi {0}. You are {1} years old!", name, age);
        }
    }
}