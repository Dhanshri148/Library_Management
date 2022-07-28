using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_INotifyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School objSchool = new School("Renuka Devi Vidyalay")
            {
                new Student{Id=1,Name="First Student",Age=16},
                new Student{Id=2,Name="Second Student",Age=18},
                new Student{Id=3,Name="Third Student",Age=19},
                new Student{Id=4,Name="Fourth Student",Age=15},
                new Student{Id=5,Name="Fifth Student",Age=14}
            };

            foreach(Student stud in objSchool)
            {
                Console.WriteLine($"{stud.Id,2}{stud.Name,-20}{stud.Age,10}");

            }
            Console.WriteLine();

            objSchool.CollectionChanged += ObjCompany_CollectionChanged;

            objSchool.Add(
                            new Student()
                            {
                                Id = 10,
                                Name = "Tenth Student",
                                Age = 15
                            });

            Student studFound = objSchool["Fourth Student"];

            objSchool.Remove(studFound);

            Console.WriteLine("--after adding an Student ,and Removing another student");
            foreach(Student stud in objSchool)
            {
                Console.WriteLine($"{stud.Id,2}{stud.Name,-20}{stud.Age,10}");
            }
            Console.WriteLine();
            
        }
        private static void ObjCompany_CollectionChanged(
           object sender,
           System.Collections.Specialized.NotifyCollectionChangedEventArgs s)
        {
            switch (s.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("The following employee(s) were ADDED!");
                    foreach (Student stud in s.NewItems)
                    {
                        Console.WriteLine($"\t{stud.Id} {stud.Name}");
                    }
                    Console.WriteLine();
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("The following employee(s) were removed!");
                    foreach (Student stud in s.OldItems)
                    {
                        Console.WriteLine($"\t{stud.Id} {stud.Name}");
                    }
                    Console.WriteLine();
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
    }
}
