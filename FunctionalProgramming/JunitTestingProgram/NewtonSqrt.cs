using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.JunitTestingProgram
{
    class NewtonSqrt
    {
        public static void newtonSqrt()
        {
            Console.Write("Enter a non Negative number :");
            int c = Utility.readInt();
            double t = c;
            double epsilon = 1e-15;
            while (Math.Abs(t-(c/t))>epsilon *t)
            {

                t = (t + (c / t)) / 2;
            }
            Console.WriteLine("Square root of "+c+" is :"+t);
        }
    }
}
