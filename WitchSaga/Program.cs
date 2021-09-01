using System;
using System.Collections.Generic;

namespace WitchSaga
{
    class Program
    {
        static void Main(string[] args)
        {
            Witch w = new Witch();
            Console.WriteLine(w.DeathperYear(0)); 

            List<Person> lst = new List<Person>();
            Person p1 = new Person();
            Person p2 = new Person();
            Console.WriteLine("Enter Person1 age of death: ");
            p1.AgeofDeath = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person1 year of death: ");
            p1.YearOfDeath = Convert.ToInt32(Console.ReadLine());
            lst.Add(p1);
            Console.WriteLine("Enter Person2 age of death: ");
            p2.AgeofDeath = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person2 year of death: ");
            p2.YearOfDeath = Convert.ToInt32(Console.ReadLine());          
            lst.Add(p2);
            double response = CoderReturn.averageDeathsperYear(lst);
            if (response!=-1)
            {
                Console.WriteLine("The average number of killed peoples is : {0}", CoderReturn.averageDeathsperYear(lst));

            }
            else
            {
                Console.WriteLine("Invalid data");
            }
            Console.ReadLine();
        }
    
    }
}
