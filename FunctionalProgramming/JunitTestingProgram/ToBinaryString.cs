using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.JunitTestingProgram
{
    class ToBinaryString
    {
        public static void toBinary()
        {
            Console.Write("Enter a number to convert it into binary string :");
            int num = Utility.readInt();
            string str = Convert.ToString(num,2);
            Console.WriteLine(str);
            string str1 = "";
            for (int i=str.Length-1;i>=0;i--)
            {
                str1 = str1 + str[i]; 
            }
            Console.WriteLine("reverse string :"+str1);
            char[] a = str1.ToCharArray();
            for (int j=0;j<str1.Length;j++)
            {
                if (a[j]=='1')
                {
                    Console.Write(Math.Pow(2,j)+" ");
                    if (j< str1.Length-1)
                        {
                        Console.Write("+ ");
                        }
                }
            }
            
        }
    }
}
 