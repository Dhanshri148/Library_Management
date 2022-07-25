using System;

namespace cs_con_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? name = "Dhanshri";
            object obj = name;
            string name1 = obj as string;
            if (name1 != null)
            {
                Console.WriteLine("Successfully Cast");
            }
            
        }
    }
}