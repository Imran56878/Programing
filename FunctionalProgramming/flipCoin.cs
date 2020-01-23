using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class flipCoin
    {
        public static void FlipCoin() {
            Console.Write("Enter a number for repeatation :");
            int n = Utility.readInt();
            int heads = 0, tails = 0;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int number = r.Next(1,10);
                if (number > 5)
                {
                    heads++;
                }
                else {
                    tails++;
                }
            }
            Console.WriteLine("head percentage :"+heads*100/n+"%");
            Console.WriteLine("head percentage :" + tails * 100 / n + "%");
        }
    }
}