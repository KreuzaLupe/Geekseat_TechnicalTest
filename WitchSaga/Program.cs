using System;
using System.Collections.Generic;

namespace WitchSaga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press to continue: ");
            int len = Convert.ToInt32(Console.ReadLine());
            List<Person> lst = new List<Person>();
            Person p1 = new Person();
            p1.YearOfDeath = 12;
            p1.Age = 10;
            lst.Add(p1);
            Person p2 = new Person();
            p2.Age = 13; p2.YearOfDeath = 17;
            lst.Add(p2);
            Console.WriteLine(CoderReturn.averageDeathsperYear(lst));
            Console.ReadLine();
        }
    
    }
}
