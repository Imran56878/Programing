using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.Algorithm
{
    class GenericMethodTest
    {
        public static  void PrintArray<E>(E[] inputarray )
        {
            foreach (E element in inputarray)
            {
                Console.Write(element +" ");
            }
            Console.WriteLine("");
        }
        public static void MethodTest()
        {
            Int32[] a = {1,2,3,7,5,9,4 };
            Char[] ch = {'H','E','L','L','O'};
            PrintArray(a);
            PrintArray(ch);

        }
    }
}
