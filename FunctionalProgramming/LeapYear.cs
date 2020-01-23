using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class LeapYear
    {
        public static void leapYear()
        {
            Console.Write("Enter year to check leap year :");
            int year = Utility.readInt();
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine("This is leap year");
                    else Console.WriteLine("This is not leap year");
                }
              else   Console.WriteLine("This is leap year");

            }
           else  Console.WriteLine("This is not leap year");
        }
    }
}
