using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.JunitTestingProgram
{
    class VendingMachine
    {
       static int th = 0, fh = 0, hun = 0, fif = 0, te = 0, five = 0, two = 0, count = 1;
        public static void jUnit()
        {
            int money = Utility.readInt();

            notes(money);
          //  Console.WriteLine("Thousand :" + th + "  five hundred :" + fh + "  hundred :" + hun + "  fifty :" + fif + "  ten :" + te + "  five :" + five + "  two :" + two);
        }
        public  static void  notes(int money) { 
            
            while (count>0)
            {
                if (money>=1000)
                {
                    th = money / 1000;
                    money = money % 1000;
                    
                   // notes(money);
                }
               else if (money>=500 )
                {
                    fh = money / 500;

                    money = money % 500;
                  }
                else if (money >= 100)
                {
                    hun = money / 100;
                    money = money % 100;
                   
                }
                else if (money >= 50 )
                {
                    fif = money / 50;
                    money = money % 50;
                    
                  //  notes(money);
                }
                else if (money >= 10)
                {
                    te = money / 10;
                    money = money % 10;
                    
                   // notes(money);
                }
                else if (money >= 5)
                {
                    five = money / 5;
                    money = money % 5;
                   
                  //  notes(money);
                }
                else if (money >= 2 )
                {
                    two = money / 2;
                    money = money % 2;
                    }
                else
                {
                    Console.WriteLine(" One :"+money);
                    count = 0;
                }

            }// while loop
            Console.WriteLine("Thousand :"+th+" , five hundred :"+fh+" , hundred :"+hun+" , fifty :"+fif+" , ten :"+te+" , five :"+five+" , two :"+two);
        }
    }
}
