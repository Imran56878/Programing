using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Account
    {
      //  public static int BankBalance = 100000;
        public void BankQueue()
        {
            BankingCash<string> len = new BankingCash<string>();
            Console.WriteLine("Enter how many customer in bank ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} customer name one by one ", c);
            for (int i = 0; i < c; i++)
            {
                string name = Console.ReadLine();
                len.enqoueue(name);
            }
            Console.WriteLine("Enter your choice");
        }
        int total = 0;
        public void TotalBalance()
        {
            Console.WriteLine("Total Balance is :"+total);
        }
        public void Deposit()
        {
            Console.Write("Enter the amount :");
           int money= int.Parse(Console.ReadLine());
            total += money;
        }
        public void Withdraw()
        {
            Console.Write("Enter the amount :");
            int money = int.Parse(Console.ReadLine());
            total -= money;

        }
      
    }
}
