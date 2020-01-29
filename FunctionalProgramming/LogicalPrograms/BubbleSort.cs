using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.LogicalPrograms
{
    class BubbleSort
    {
        public static void bubbleSort()
        {
            Console.Write("Enter the length of array :");
            int n = Utility.readInt();
            int[] a = new int[n];
            int i, j, temp;
            Console.WriteLine("Enter the array elements :");
            for (i = 0; i < n; i++)
            {
                a[i] = Utility.readInt();
            }
            Console.WriteLine("inserted elemnt :");
            foreach (int c in a)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\nSorted elemnt is :");
            for (i=0;i<n;i++)
            {
                for (j=0;j<n-1-i;j++)
                {
                    if (a[j]>a[j+1])
                    {
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j + 1] = temp;
                    }
                }

            }
            foreach (int p in a)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine("\nEnd of program");
        }
    }
}
