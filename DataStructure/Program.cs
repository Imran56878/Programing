using System;

namespace DataStructure
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.Write("Enter your choice : 1: Ordered  and 2:Unordered");
            int option = int.Parse(Console .ReadLine ());
            switch (option) 
            {
               
             case 1:
                    { 
                     OrderedListTest li = new OrderedListTest();
                     li.list();
                    }
                    break;
             
             case 2:
                    { 
                    UnorderedTest lm = new UnorderedTest();
                    lm.Test2();
                    }
                    break;

             default:
                    Console.WriteLine("YOu have enterd wrong choice ");
                    break;

            }
        }
    }
}
