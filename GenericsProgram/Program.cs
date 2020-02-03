using System;

namespace GenericsProgram
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("1: Simple generic test ");
            Console.WriteLine("2: Generic bubble sort ");
            int Option = Utility.readInt();
            Console.WriteLine("your Option is :"+Option );
            switch (Option )
            {
                case 1:
                    SimpleGenericTest.Test();
                    break;
                case 2:
                    BubbleSortGeneric.BubbleMethod();
                    break;

                default:
                    Console.WriteLine("You have enterd wrong choice ");
                    break ;
            }
           
        }
    }
}
