using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class PrimeFactor
    {
        public static void primeFactor()
        {
            Console.Write("Enter a number to find a prime factor :");
            Console.WriteLine(" ");
            int num = Utility.readInt();
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    num = num / i;
                    Console.Write(i+" ");
                }
            }
                if (num>2)
                {
                    Console.WriteLine(num);
                }
            
        }
    }
}
