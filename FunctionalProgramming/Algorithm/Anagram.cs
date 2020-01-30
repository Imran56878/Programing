using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.Algorithm
{
    class Anagram
    {
       public static void StringAnagram()
        {
            // Console.WriteLine("imr".CompareTo ("Imra"));//it will return -1
            Console.Write("Enter first string :");
            string str1 = Utility.readString();
            Console.Write("Enter second string :");
            string str2 = Utility.readString();
            char[] arr1 = str1.Trim().ToCharArray();
            char[] arr2 =str2.Trim().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string m1 = new string (arr1 );//string s= arr1.ToString() will not work here.
            string m2 = new string(arr2); // string s = String.Concat( c );

            if (m1.Equals(m2))
            {
                Console.WriteLine("Given string is anagram ");
            }
            else { Console.WriteLine("String is not anagram "); }

        }
    }
}
