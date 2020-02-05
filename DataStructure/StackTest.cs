using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class StackTest
    {
        public void testMethod()
        {
            StackOperation<int> l = new StackOperation<int>();
          start:  
            Console.WriteLine("1: Push element ");
            Console.WriteLine("2: Pop element ");
            Console.WriteLine("3: Display element ");
            Console.WriteLine("4: isEmpty ");
            Console.Write("Enter the option");
            int option = int.Parse(Console.ReadLine());
            switch (option ) {
                case 1:
                    Console.WriteLine("Enter a number to push");
                    l.push(int.Parse(Console.ReadLine()));
                  goto start;

                case 2:
                    l.pop();
                  goto start;

                case 3:
                    l.display();
                  goto start;

                case 4:
                  bool s=  l.isEmpty ();
                    if (s==true)
                    {
                        Console.WriteLine("List is empty ");
                    }
                    else Console.WriteLine("List is not empty ");
                    goto start;

                default:
                    Console.WriteLine("You have entered  wrong option");
                  break;
            }

           
           
           
        }
    }
}
