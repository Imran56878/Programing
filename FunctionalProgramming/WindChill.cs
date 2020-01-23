using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class WindChill
    {
        public static void windChill()
        {
            Console.WriteLine("Enter temprature  nad speed ");
            double t = Utility.readLong();
            double v = Utility.readLong();
            double w = 35.74 + 0.62515 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            if (t < 50 && v < 120 && v > 3)
            {
                Console.WriteLine("Absolute value " + w);
            }
            else Console.WriteLine("Value is in range");
           

        }
    }
}
