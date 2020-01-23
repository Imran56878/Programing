using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class StopWatch
    {
       static  DateTime d = new DateTime();
        public static void stopWatch()
        {
            start();
            int n = Utility.readInt();
            if (n > 0) 
             stop();
            Console.WriteLine(d.TimeOfDay);
            
        }
        public static void start()
        {
            Console.WriteLine("H :" + d.Hour + " m :" + d.Minute + " s :" + d.Second);
        }
        public static void stop()
        {
            Console.WriteLine("H :" + d.Hour + " m :" + d.Minute + " s :" + d.Second);
        }
    }
}
