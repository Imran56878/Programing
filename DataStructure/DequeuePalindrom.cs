using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class DequeuePalindrom
    {
        public void check()
        {
            DeQueue <char> d = new DeQueue<char>();
            start:
            Console.WriteLine("1 :Add Front ");
            Console.WriteLine("2 :Add Rear ");
            Console.WriteLine("3 :Remove Front ");
            Console.WriteLine("4 :Remove Rear ");
            Console.WriteLine("5 :Show Method ");
            Console.WriteLine("6 :Size of List ");
            Console.WriteLine("7 :isEmpty ");
            Console.Write("Enter your choice :");
            switch (int.Parse (Console.ReadLine ()))
            {
                case 1:
                    Console.WriteLine("Enter the char value");
                    d.addFront(char .Parse (Console .ReadLine ()));
                   goto start;

                case 2:
                    Console.WriteLine("Enter the char value");
                    d.addRear(char.Parse(Console.ReadLine()));
                    goto start;

                case 3:  
                    try
                    {
                        Console.WriteLine("Removed Element is :" + d.removeFront());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message );
                    }

                    goto start;

                case 4:
                    try
                    {
                        Console.WriteLine("Removed Element is :" + d.removeRear());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    goto start;

                case 5:
                    d.Show();
                    goto start;

                case 6:
                    Console.WriteLine("size is :" + d.Size());
                    goto start;

                case 7:
                    Console.WriteLine (d.isEmpty());
                    goto start;

                default:
                    Console.WriteLine("You have entered wrong value");
                    break;


            }
                     
           
          
        }                                        
    }
}
