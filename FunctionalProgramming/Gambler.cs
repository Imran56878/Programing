using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Gambler
    {
        public static void  GamblerCheck()
        {
            int bets = 0,wins=0;
            Console.Write("Enter stack value , goals and traials value :");
            int stack = Utility.readInt();
            int goals = Utility.readInt();
            int trials = Utility.readInt();
           Random r = new Random();
            double m;
            for (int i=0;i<trials;i++)
            {
                int cash = stack;
                while (cash > 0.5 && cash < goals)
                {
                    bets++;
                    m= r.NextDouble();
                    // Console.Write(m+" ");
                    if (m > 0.5)
                    {
                        cash++;
                    }
                    else cash--;

                }
                    
                    if (cash ==goals)
                    {
                        wins++;
                    }
                
            }
            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
            Console.WriteLine("Avg # bets           = " + 1.0 * bets / trials);
           

        }
    }
}
