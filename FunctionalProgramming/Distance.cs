using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Distance
    {
        public static void distance()
        {
            Console.WriteLine("Enter the x and y cordinate value :");
            int x = Utility.readInt();
            int y = Utility.readInt();
            double m = Math.Sqrt(x*x+y*y);
            Console.WriteLine("Euclidean distance :"+m);
        }
    }
}
