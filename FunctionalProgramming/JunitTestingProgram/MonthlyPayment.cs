using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.JunitTestingProgram
{
    class MonthlyPayment
    {
        public static void Payment()
        {
            Console.WriteLine("Enter principle amount P , number of year Y , rate of interest R");
            double P, Y, R,payment;
            P = Utility.readDouble();
            Y = Utility.readDouble();
            R = Utility.readDouble();
            double n = 12 * Y;
            double r = R /1200;
            double m = Math.Pow((1+r),(-n));
            payment = (P * r) / (1 - m);
            Console.WriteLine("Payment amount is :"+payment);

        }
    }
}
