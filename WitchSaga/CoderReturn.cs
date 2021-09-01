using System;
using System.Collections.Generic;
using System.Text;

namespace WitchSaga
{
    public class CoderReturn
    {
        //method that takes a list of persons and return the average number of deaths on year of birth of the persons
        public static double averageDeathsperYear(List<Person> persons)
        {
            int i = 0;
            int birthYear = 0;

            foreach (var p in persons)
            {
                birthYear = p.YearOfDeath - p.Age;
                //if the person had died before the year when witch took controll or
                //the age is not correct or
                //birth year was before the year when witch took controll the method skips the calculation and returns -1 

                if (p.YearOfDeath < 1 || p.Age < 0 || birthYear < 1|| p.Age> 120)
                {
                    return -1;
                }
                else
                {
                    //else we count and add for each person , the  deaths on the year when tha  person was born
                    i = i + Witch.DeathperYear(birthYear);
                }
            }

            // we calculate the avg number and convert it to double
            return Convert.ToDouble(i) / Convert.ToDouble(persons.Count);
        }

    }
}
