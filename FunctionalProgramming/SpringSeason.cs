using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class SpringSeason
    {
        public static void springSeason()
        {
            Boolean a =true;
            int count = 1;
            Console.WriteLine("Enter day, month and year respectively (d,m)=(3,20 to 6,20)  ");
            int d = Utility.readInt();
            int m = Utility.readInt();
            int y = Utility.readInt();
            if ((m==4||m==6||m==10)&&d==31)
            {
                Console.WriteLine("Invalid input");
                count=0;
            }
            while (count == 1)
            {
                if (m >= 3 && m <= 6)
                {
                    if (m == 3 && d < 20)
                    {
                        a = false;
                    }
                    else if (m == 6 && d > 20)
                    {
                        a = false;
                    }
                    else a = true;
                }
                else
                {
                    a = false;
                }
                
            if (a==true)
            {
                Console.WriteLine("You are in :spring season");
            }
            else Console.WriteLine("This is not a:spring season ");
                count = 0;
            }
        }
    }
}
