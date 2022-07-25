using System;
namespace cs_con_DisplayNameDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime aDate = DateTime.Now;
            Console.Write("Enter name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Hi "+name);
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(aDate.ToString("dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(aDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
        }
    }
}