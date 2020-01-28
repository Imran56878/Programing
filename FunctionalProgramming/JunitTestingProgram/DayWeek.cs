using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.JunitTestingProgram
{
    class DayWeek
    {
        public static void  Day1()
        {
            int d, m, y, m1, y1, d1,x;
            d = Utility.readInt();
            m = Utility.readInt();
            y = Utility.readInt();
            y1 = y - (14 - m) / 12;
            x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            m1 = m + 12 * ((14 - m) / 12) - 2;
            d1 = (d + x + 31 * m1 / 12) % 7;
            switch (d1)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Wrong answer");
                    break;
            }
        }
    }
}
