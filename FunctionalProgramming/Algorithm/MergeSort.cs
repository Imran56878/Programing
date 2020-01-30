using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.Algorithm 
{
    class MergeSort
    {
        public static void mergeSort()
        {
            Console.Write("Enter the length of array :");
            int n = Utility.readInt();
            string [] a = new string [n];
            int i;
            Console.WriteLine("Enter the String array elements :");
            for (i = 0; i < n; i++)
            {
                a[i] = Utility.readString ();
            }
            Console.WriteLine("inserted elemnt :");
            foreach (string  c in a)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine(" ");

           string []arr1= MgSort(a);
            Console.WriteLine("Sorted string :");
            for (int j = 0; j < arr1.Length; j++)
            {
                Console .WriteLine(arr1[j] + " ");
            }
        }
        public static string [] MgSort(string []arr)
        {
            
            int len = arr.Length;
            string[] sorted = new string [len];
            if (len==1) 
               {

                sorted = arr;
               }
            else { 
            int mid = len / 2;
            string[] left = null;
            string[] right = null;
            int mid1 = len / 2;
                 if (len%2==0)
                   {
                    left = new string[mid1];
                    right = new string[mid1];
                   }
                 else
                     {
                     left = new string[mid1];
                     right = new string[mid1+1];
                      }
                int x = 0;
                int y = 0;
                for (x=0; x < mid; x++)
                {
                    left[x] = arr[x];
                }
                for (x=mid; x < arr.Length; x++)
                {
                    right[y++] = arr[x];
                }
                left =  MgSort(left);
                right=MgSort(right);
                sorted=Merge(left,right);
            }

            return sorted;
        }
        public static string [] Merge(string [] left,string [] right)
        {
            string[] m = new string[left.Length +right .Length ];
            //String[] merged = new String[left.length + right.length];
            int lIndex = 0;
            int rIndex = 0;
            int mIndex = 0;
            int comp = 0;
            while (lIndex < left.Length || rIndex < right.Length)
            {
                if (lIndex == left.Length)
                {
                    m[mIndex++] = right[rIndex++];
                }
                else if (rIndex == right.Length)
                {
                    m[mIndex++] = left[lIndex++];
                }
                else
                {
                    comp = (left[lIndex]).CompareTo(right[rIndex]);
                    if (comp > 0)
                    {
                        m[mIndex++] = right[rIndex++];
                    }
                    else if (comp < 0)
                    {
                        m[mIndex++] = left[lIndex++];
                    }
                    else
                    {
                        m[mIndex++] = left[lIndex++];
                    }
                }
            }
            




            return m;
        }
    }
}
