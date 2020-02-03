using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.Algorithm
{
    class GenericBubble//<t>//where t: IComparable
    {

        public static void BubbleMethod()
        {
            Console.WriteLine("Enter the length of array");
            int len = Utility.readInt();
            Console.WriteLine("Enter the lement (First press 1 for integer and 0 for string )");
            var a = Console.ReadLine();
            if (a == "1")
            {
                int[] arr = new int[len];
                for (int i = 0; i < len; i++)
                {
                    arr[i] = Utility.readInt();
                }
                int[] b = BubbleSort<int>(arr);
            }
            else
            {
                string[] arr = new string [len];
                for (int j = 0; j < len; j++)
                {
                    arr[j] = Utility.readString();
                }
                string[] b = BubbleSort<string >(arr);
            }
           
           // t b = BubbleSort(arr1);
        }
        public static t[] BubbleSort<t>(t[]arr )where t: IComparable
        {
          //  Console.WriteLine("Enter the length ");
            int n = arr.Length;
            t[] a = new t[n];
            for (int i=0;i<n;i++)
            {
                a[i] = arr[i];
            }
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n-1-i;j++)
                {
                   if ((a[j]).CompareTo( a[j + 1])>0)
                    {
                        t temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }
    }
}
