using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Coupon
    {
        public static void CouponA()
        {
            int num, i = 1, x = 1, j,count=0;
            Random r = new Random();
            Console.WriteLine("Enter a term how many distinct coupon do you want ");
           int  n = Utility.readInt();
            int[] a = new int[n];
            while (x >0)
            {
                for (i=0; i<n;i++)
                {
                    num = r.Next(1,n+1);
                    Console.Write(i+"^th value :"+ num+" ");
                    if (i==0)
                    {
                        a[i] = num;
                    }
                    for (j = 0; j < i; j++)
                    {
                        if (num != a[j]&&a[i]==0)
                        {
                            count = 1;
                        }
                        else
                        {
                            count = 0;
                            if (a[i] == 0) { i = i - 1; }
                        }
                    }
                    if (count==1)
                    {
                        a[i] = num;
                    }
                    if (i == n - 1)
                    {
                        x = 0;
                    }
                }


            }
            Console.WriteLine(" ");
            for (i=0;i<n;i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
