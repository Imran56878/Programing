using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class OrderedListTest
    {
        public void list()
        {
            OrderedList<int> list = new OrderedList<int>();
        start:
            Console.WriteLine();
            Console.WriteLine("1. Adding element in the list ");
            Console.WriteLine("2. Searching  in the list ");
            Console.WriteLine("3. Removing Element ");
            Console.WriteLine("4. Show element ");
            Console.WriteLine("5. Index of  Element ");
            Console.WriteLine("6. Pop position ");
            Console.WriteLine("Enter your choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter your number ");
                    int item = int.Parse(Console.ReadLine());
                    list.Add(item);
                    list.Show();
                    goto start;
                case 2:
                    Console.WriteLine("Enter any number to search ");
                    int num = int.Parse(Console.ReadLine ());
                    if (list.Search(num) == true)
                        Console.WriteLine("number is found");
                    else Console.WriteLine("number not found");
                    goto start;
                case 3:
                    Console.WriteLine("\nEnter any number to remove ");
                    list.Remove(int.Parse(Console.ReadLine()));
                    goto start;
                case 4:
                    list.Show();
                    goto start;
                case 5:
                    Console.WriteLine(" Enter any number to get index ");
                    int r=  list.Index(int.Parse(Console.ReadLine()));
                    Console.WriteLine("index is :"+r);
                    goto start;
                case 6:
                    Console.WriteLine(" Enter the position to delete element ");
                    list.PopPosition(int.Parse(Console.ReadLine()));
                    goto start;
                case 7:
                    int a = list.Size();
                    Console.WriteLine("The size is :"+a);
                    goto start;

                default:
                    Console.WriteLine("You have entered bwrong choice");
                    break;
            }
        }
    }
}
