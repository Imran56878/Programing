using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.LogicalPrograms
{
    class NprimeNumber
    {
        public static void Nprime()
        {
            int i, j;
            int m= 0;
            Console.WriteLine("Enter the range");
            int num = Utility.readInt();
            Console.Write(2+" ");
            for (i=3;i<num;i++)
            {
                for (j=2;j<i;j++)
                {
                    if (i % j != 0)
                    {
                        m = 1;
                    }
                    else
                    {
                        m = 0;
                        break;
                    }
                }
                if (m==1) { 
                Console.Write(i+" ");
                 } 
            }
        }
    }
}
