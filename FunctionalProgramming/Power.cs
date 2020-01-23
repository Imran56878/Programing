using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Power
    {
        public static void powerSeries( )
        {
            Console.Write("Enter a number to define term :");
            int  n = Utility.readInt();
            for(int i = 0; i < n; i++)
            {
                Console.Write(Math.Pow(2, i)+" ");
            }
        }
    }
}
