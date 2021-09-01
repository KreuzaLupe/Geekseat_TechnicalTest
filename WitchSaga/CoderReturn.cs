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
            Witch w = new Witch();

            foreach (var p in persons)
            {
                birthYear = p.YearOfDeath - p.AgeofDeath;
                //if the person had died before the year when witch took controll or
                //the age is not correct or
                //birth year was before the year when witch took controll the method skips the calculation and returns -1 
                //ps: i added an additional control for the age and decided to allow a max = 149 years otherwise the data entered is considered to beinvalid

                if (p.YearOfDeath < w.FirstYearOfControl || p.AgeofDeath < 0 || birthYear < w.FirstYearOfControl|| p.AgeofDeath > 150)
                {
                    return -1;
                }
                else
                {
                    //else we count and add for each person , the  deaths on the year when tha  person was born
                    i = i + w.DeathperYear(birthYear);
                }
            }

            // we calculate the avg number and convert it to double
            return Convert.ToDouble(i) / Convert.ToDouble(persons.Count);
        }

    }
}
