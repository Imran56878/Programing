using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.JunitTestingProgram
{
    class TempratureConversion
    {
        public static void tempF()
        {
            Console.Write("Enteer temprature in fahrenheit:");
            double tf = Utility.readDouble();
            double c = (tf - 32) * 5 / 9;
            Console.WriteLine("Temprature in Celsius :"+c);
        }
        public static void tempC()
        {
            Console.Write("Enteer temprature in Celsius:");
            double tc = Utility.readDouble();
            double f = (tc * (9/5))+32;
            Console.WriteLine("Temprature in Fahrenheit :" + f);
        }
    }
}
