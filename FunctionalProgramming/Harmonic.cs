using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Harmonic
    {
        public static void harmonicNumber()
        {
            Console.Write("Enter a term to find a harmonic series :");
            int n = Utility.readInt();
            for(int i = 1; i <= n; i++)
            {
                Console.Write("1/"+i+" ");
                if (i < n)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine("\n Above seriese is harmonic number series ");
            Console.WriteLine("Harmonic n^th number(Last term) :"+"1/"+n);
        }
    }
}
