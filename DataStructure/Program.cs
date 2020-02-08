using System;

namespace DataStructure
{
    class Program
    {
        
        static void Main(string[] args)
        {
          start:
            Console.WriteLine("1: Ordered");
            Console.WriteLine("2: Unordered");
            Console.WriteLine("3: Stack");
            Console.WriteLine("4: Parenthesis Balance");
            Console.WriteLine("5: Banking");
            Console.Write("Enter your choice : ");
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

                case 3:
                    StackTest st = new StackTest();
                    st.testMethod();
                    break;
                case 4:
                    BalanceParenthesis bl = new BalanceParenthesis();
                    bl.Check();
                    goto start;
                case 5:
                    Customer c = new Customer();
                    c.Check();
                    goto start;

             default:
                    Console.WriteLine("YOu have enterd wrong choice ");
                    break;

            }
        }
    }
}
