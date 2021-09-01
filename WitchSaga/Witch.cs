using System;
using System.Collections.Generic;
using System.Text;

namespace WitchSaga
{
   public class Witch
    {
        public int FirstYearOfControl
        {
            //the witch took control in year 1

            get { return 1; }
            set { }
        }

        //method that calucates the number of deaths in base of the year
        //from the example for the first year i calculated that the arithmetic expression is Fibonacci(n+2)-1
       
        public int DeathperYear(int year)
        {
            //the witch took control in year 1, so if year is before we should calculate any deaths
            if (year < 1)
            {
                return -1;
            }
            else
            {
                return FibonacciNumbers(year + 2) - 1;
            }
        }

        //method which calculates the fibonacci series, ad given a specific  length (n), it returns the fibonacci series number corresponding to that
        public static int FibonacciNumbers(int n)
        {
            int firstNr = 0, secNr = 1, res = 0;

            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            for (int i = 2; i <= n; i++)
            {
                res = firstNr + secNr;
                firstNr = secNr;
                secNr = res;
            }
            return res;
        }
    }
}
