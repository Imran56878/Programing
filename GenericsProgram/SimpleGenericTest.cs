using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsProgram
{
    class SimpleGenericTest
    {
        public void add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
            /* if (d1 > d2)
             {
                 Console.WriteLine("Hello Program");
             }*/
        }
        public void Sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mult<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
        public static void Test()
        {
            SimpleGenericTest test1 = new SimpleGenericTest();
            SimpleGenericTest test2 = new SimpleGenericTest();
            Console.WriteLine("OUtput in integer formate :");
            test1.add<int>(10,5);
            test1.Sub<int>(10, 5);
            test1.Mult<int>(10, 5);
            test1.Div<int>(10,5);
            Console.WriteLine("OUtput in double formate :");
            
            test2.add<double>(10, 5);
            test2.Sub<double>(10, 5);
            test2.Mult<double >(10, 5.5);
            test2.Div<double>(10, 3);
        }
    }
}
