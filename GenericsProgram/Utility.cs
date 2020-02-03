using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsProgram
{
    class Utility
    {
        public static  int readInt()
        {
            return Convert .ToInt32 (Console.ReadLine());
        }
        public static String readString()
        {
            return (Console.ReadLine());
        }
        public static long readLong()
        {
            return long.Parse(Console.ReadLine());
        }
        public static double readDouble()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
