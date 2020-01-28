using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.JunitTestingProgram
{
    class BinaryNibbling
    {
        public static void Nibbling()
        {
            Console.WriteLine("Enter a integer number ");
            int num=Utility .readInt ();
            int nib = ((num & 0x0f) << 4 | (num & 0xf0) >> 4);
            Console.WriteLine("After nibble process , number is :"+nib);
            // Console.WriteLine("int is :"+str);
            string str1 = Convert.ToString(nib, 2);
            string str2 = Convert.ToString(num, 2);
            Console.WriteLine("binary form of given number is "+str2);
            Console.WriteLine("binary form of nibble number is " + str1);
            int x = 1;
            while (x > 0)
            {
                for (int i=0;i<nib;i++)
                if (Math.Pow(2, i) == nib)
                {
                    Console.WriteLine(" Resultant number is in 2's power ");
                        i = nib;
                        x = 0;

                }
            }
        }
    }
}
