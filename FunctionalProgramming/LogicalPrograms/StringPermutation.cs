using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.LogicalProgram
{
    class StringPermutation
    {
        public static void combString(String s)
        {
            Console.WriteLine(s);
            char[] a = s.ToCharArray();
            int n = a.Length;
            int[] p = new int[n]; 
            int i = 1; 
            while (i < n)
            {
                if (p[i] < i)
                { 
                    int j = ((i % 2) == 0) ? 0 : p[i];
                    swap(a, i, j);
                    // Print current
                   Console.WriteLine(join(a));
                    p[i]++; 
                    i = 1; 
                }
                else
                {
                    p[i] = 0;
                    i++;
                }
            }
        }

        private static String join(char[] a)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(a);
            return builder.ToString();
        }

        private static void swap(char[] a, int i, int j)
        {
            char temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

    }
}
