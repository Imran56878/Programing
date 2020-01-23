using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace FunctionalProgramming
{
    class StopDemo
    {
        public static void stopDemo()
        {
            var sw = Stopwatch.StartNew();
           // Console.WriteLine("Enter a number");
           // int num = Utility.readInt();
           // if (num > 0)
           // { }
                long ticks = sw.ElapsedTicks;
                Console.WriteLine(ticks);
            
            
        } 
    }
}
