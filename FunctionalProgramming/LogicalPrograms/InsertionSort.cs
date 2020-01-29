using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.LogicalPrograms
{
    class InsertionSort
    {
        public static void insertionSort()
        {
            Console.Write("Enter the length of array :");
            int n = Utility.readInt();
            string [] a = new string [n];
            int i, j;
            string k;
            Console.WriteLine("Enter the String array elements :");
            for (i=0;i<n;i++)
            {
                a[i] = Utility.readString  ();
            }
            Console.WriteLine("inserted elemnt :");
            foreach (string c in a)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine("\nSorted String is :");
            for ( i=1;i<n;i++)
            {
                 k = a[i];
                for ( j=i-1;j>=0&&k.CompareTo(a[j])<0;j--)
                {
                    a[j + 1] = a[j];
                }
                a[j + 1] = k;
            }
            foreach(string  p in a)
            {
                Console.Write(p+" ");
            }
        }
    }
}
