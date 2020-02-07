using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadPrograms
{
    class ThreadTest
    {
        public void Test()
        {
            Thread obj1 = new Thread(Function1);
            Thread obj2 = new Thread(Function2);
            obj1.Start();
            obj2.Start();
        }
        public static void Function1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Function1 is executed :" + i.ToString());
            }
        }
        public static void Function2()
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("Function 2 is executed :" + j.ToString());
            }
        }
    }
}
