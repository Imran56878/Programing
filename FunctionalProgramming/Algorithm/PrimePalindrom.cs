using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.Algorithm
{
    class PrimePalindrom
    {
        public static void Primepalindrom()
        {
            int i;
           // int m = 0;
            Console.WriteLine("Enter the range");
            int num = Utility.readInt();
            Console.WriteLine("Prime palindrom numbers ");
            for (i = 2; i < num; i++)
            {
                if (isPrime(i))
                {
                    if (isPalindrom(i))
                    {
                        Console.Write(i+" ");
                    }
                }
            }

        }
        public static Boolean isPrime(int i)
        {
            int count = 1;
            for(int j=2;j<i;j++)
            {
                if (i % j != 0)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                    break;
                }
            }
            if (count == 1)
            {
                return true;
            }
            else return false;

            
        }
        public static Boolean isPalindrom(int num)
        {
            int a, rev = 0;
            int temp = num;
            while (num>0)
            {
             a=num%10;
                num = num / 10;
                rev = rev * 10 + a;
            }
            if (temp == rev)
            {
                return true;
            }
            else return false;
        }
    }
}
