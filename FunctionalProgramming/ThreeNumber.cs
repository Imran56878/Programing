using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class ThreeNumber
    {
        public static void threeNumber()
        {
            int i, j, k;
            Console.WriteLine("Enteer the length of array");
            int n = Utility.readInt();
            Console.WriteLine("Enter n different element of integer type :");
            int [] arr  = new int[n];
            for (i=0;i<n;i++)
            {
                arr[i] = Utility.readInt();
            }
            for (i = 0; i < n; i++)
            {
                for (j=1;j<n;j++)
                {
                    for (k=2;k<n;k++)
                    {
                        if (i < j && j < k)
                        {
                            if (arr[i]+arr[j]+arr[k]==0)
                            {
                               
                                Console.Write("("+arr[i]+","+arr[j]+","+arr[k]+"\n");
                            }
                        }
                    }
                  //  Console.WriteLine(" ");
                }

            }




        }
    }
}
