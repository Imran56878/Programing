using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.Algorithm
{
    class GenericTestClass<t1,t2>
    {
        public void display(t1 var1 , t2 var2)
        {
            Console.WriteLine("Name :"+var1+" ,ID :"+var2);
        }
       /* public static void  TestMethod1()
        {
            GenericTestClass<string, int> ob = new GenericTestClass<string, int>();
            ob.display("Imran",56878);
        } */
    }
}
