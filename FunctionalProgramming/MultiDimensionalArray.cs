using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class MultiDimensionalArray
    {
        
       static  int m = Utility.readInt();
       static  int n = Utility.readInt();

        static int[,] a = new int[m, n];
        public static void ArraymultiDimension()
        {
            int i, j;
            Console.Write("Enter m rows and n coloms element after m and n dimension");
           
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i,j] = Utility.readInt();
                }
            }

        }
        public static void getArray()
        {
            int i,j;
            for(i=0; i<m;i++)
            {
                for (j = 0; j <n; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
