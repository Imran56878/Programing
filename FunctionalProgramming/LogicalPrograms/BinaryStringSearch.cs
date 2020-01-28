using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FunctionalProgramming.LogicalPrograms
{
    class BinaryStringSearch
    {
        public static void  BinSearch()
        {
            Console.WriteLine("Enter the key value ");
            string key = Utility.readString();
            string  path = @"E:\\pro\TestBin.txt";
            string str = File.ReadAllText(path);
            string[] arr = str.Split(" ");
            // sorting in binary search
            Array.Sort(arr);
            Console.WriteLine("Sorted array");
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
            int n = binarySearch(key ,arr);
            if (n != -1)
            {
                Console.WriteLine("\nElement found at :" + n);
            }
            else
                Console.WriteLine("\nElement not found ");
        }
        public static int binarySearch(string key,string [] arr)
        {
            int start = 0;
            int last = arr.Length-1;
            while(start <=last)
            {
                int mid = (start + last) / 2;
                
                    if (key.CompareTo(arr[mid])==0)
                    {
                        return mid;
                    }
                    else if (key.CompareTo(arr[mid]) > 0)
                    {
                    start = mid + 1;
                    }
                else 
                    {
                    last = mid - 1;
                    }


            }
            return -1;
        }
    }
}
