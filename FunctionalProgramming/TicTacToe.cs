using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class TicTacToe
    {
        public static void ticTacToe()
        {
            int[] a = new int[9];
            for (int j=0;j<9;j++)
            {
                a[j] = -1;
            }
            int player = 1,num,num1,count=0,count1=0,count2=0;
            Random r = new Random();
            while (count<9) {
                while (player == 1&&count<9)
                {
                    Console.WriteLine(" Enter a number between 0 to 8 ");
                    num = Utility.readInt();
                    if (a[num] == -1)
                    {
                        a[num] = 1;
                        count++;
                        count1++;
                        player = 2;
                    }
                    else
                    {
                        Console.WriteLine("Enter other number :"+num+" is already filled by "+a[num]);
                        //  num = Utility.readInt();
                    }
                    if (count1>2) { 
                    if (num==4&&(a[num]+a[num-1]+a[num+1]==3|| a[num] + a[num - 2] + a[num + 2] == 3 || a[num] + a[num - 3] + a[num + 3] == 3) )
                    {
                        count = 9;
                    }
                    else if (num == 2 && (a[num] + a[num - 1] + a[num - 2] == 3 || a[num] + a[num + 3] + a[num + 6] == 3))
                    {
                        count = 9;
                    }
                    else if (num==8&&(a[num]+a[num-1]+a[num-2]==3))
                    {
                        count = 9;
                    }
                    else if (num == 6 && (a[num] + a[num - 3] + a[num - 6] == 3))
                    {
                        count = 9;
                    }
                    else if (num == 0 && (a[num] + a[num +3] + a[num +6] == 3))
                    {
                        count = 9;
                    }
                        else if (num == 1 && (a[0] + a[1] + a[2] == 3 || a[1] + a[4] + a[7] == 3))
                        {
                            count = 9;
                        }
                        else if (num == 3 && (a[0] + a[3] + a[6] == 3 || a[3] + a[4] + a[5] == 3))
                        {
                            count = 9;
                        }
                        else if (num == 7 && (a[6] + a[7] + a[8] == 3 || a[7] + a[4] + a[1] == 3))
                        {
                            count = 9;
                        }
                        else if (num == 5 && (a[5] + a[8] + a[2] == 3 || a[5] + a[4] + a[3] == 3))
                        {
                            count = 9;
                        }
                    }
            }
                while (player == 2&&count<9)
                {
                    num1 = r.Next(0, 9);
                    if (a[num1] == -1)
                    {
                        a[num1] = 2;
                        Console.WriteLine(num1 +" is filled by Computer :");
                        count++;
                        count2++;
                        player = 1;
                    }
                    /* else
                     {
                         Console.WriteLine(num1+" is already filled by "+a[num1]);
                     } */
                    if (count2>2) { 
                    if (num1==4&&(a[num1] + a[num1 - 1] + a[num1 + 1] == 6 || a[num1] + a[num1 - 2] + a[num1 + 2] == 6 || a[num1] + a[num1 - 3] + a[num1 + 3] == 6))
                    {
                        count = 9;
                    }
                    else if (num1==2&&(a[num1]+a[num1-1]+a[num1-2]==6||a[num1]+a[num1+3]+a[num1+6]==6))
                    {
                        count = 9;
                    }
                    else if (num1 == 8 && (a[num1] + a[num1 - 1] + a[num1 - 2] == 6))
                    {
                        count = 9;
                    }
                    else if (num1 == 6 && (a[num1] + a[num1  -3] + a[num1 - 6] == 6))
                    {
                        count = 9;
                    }
                    else if (num1 == 0 && (a[0] + a[3] + a[6] == 6||a[0]+a[1]+a[2]==6||a[0]+a[4]+a[8]==6))
                    {
                        count = 9;
                    }
                        else if (num1 == 1 && (a[0] + a[1] + a[2] == 6||a[1]+a[4]+a[7]==6))
                        {
                            count = 9;
                        }
                        else if (num1 == 3 && (a[0] + a[3] + a[6] == 6 || a[3] + a[4] + a[5] == 6))
                        {
                            count = 9;
                        }
                        else if (num1 == 7 && (a[6] + a[7] + a[8] == 6 || a[7] + a[4] + a[1] == 6))
                        {
                            count = 9;
                        }
                        
                        else  if (num1 == 5 && (a[5] + a[8] + a[2] == 6 || a[5] + a[4] + a[3] == 6))
                        {
                            count = 9;
                        }
                    }
            }
            }
            if ((a[0]+a[1]+a[2]==3)|| (a[3] + a[4] + a[5] == 3) || (a[6] + a[7] + a[8] == 3) || (a[0] + a[3] + a[6] == 3) || (a[1] + a[4] + a[7] == 3) || (a[2] + a[5] + a[8] == 3) || (a[0] + a[4] + a[8] == 3) || (a[2] + a[4] + a[6] == 3) )
            {
                Console.WriteLine("player 1 is winner ");
            }
            if ((a[0] + a[1] + a[2] == 6) || (a[3] + a[4] + a[5] == 6) || (a[6] + a[7] + a[8] == 6) || (a[0] + a[3] + a[6] == 6) || (a[1] + a[4] + a[7] == 6) || (a[2] + a[5] + a[8] == 6) || (a[0] + a[4] + a[8] == 6) || (a[2] + a[4] + a[6] == 6))

            {
                Console.WriteLine("player 2( Computer ) is winner ");
            }
           }
    }
}
