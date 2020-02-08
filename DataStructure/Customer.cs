using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Customer
    {
        public void Check()
        {
            BankingCash<string> b = new BankingCash<string>();
           start:
             Console.WriteLine("1 : enqueue");
            Console.WriteLine("2 : Show");
            Console.WriteLine("3 : Dequeue");
            Console.WriteLine("Enter an option to execute ");
            int option = int.Parse(Console .ReadLine());
            switch (option )
            {
                case 1:
                    Console.Write("Enter customer name in Queue :");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter {0} customer name one by one ", n);
                    for (int i = 0; i < n; i++)
                    {
                        string name = Console.ReadLine();
                        b.enqoueue(name);
                    }
                    goto start;

                case 2:
                    b.Show();
                    goto start;
                   
                case 3:
                    b.dequeue ();
                    goto start; 

                default:
                    Console.WriteLine("This is default case");
                    break;
            }
            
         
           
        }
       
    }
}
