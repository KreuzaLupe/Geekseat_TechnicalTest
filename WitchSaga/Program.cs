using System;
using System.Collections.Generic;

namespace WitchSaga
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst = new List<Person>();
            Person p1 = new Person();
            Person p2 = new Person();
            Console.WriteLine("Enter Person1 age: ");
            p1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person1 Year of Death: ");
            p1.YearOfDeath = Convert.ToInt32(Console.ReadLine());
            lst.Add(p1);
            Console.WriteLine("Enter Person2 age: ");
            p2.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person2 Year of Death: ");
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
