using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class UnorderedTest
    {
        public void Test2()
        {


            UnOrdered1<int> q = new UnOrdered1<int> ();
            q.Add(5);
            q.Add(6);
            q.Add(7);
            q.Add(8);
            q.Add(9);
            q.Add(10);
            q.Add(11);
            int count = q.Size();
            Console.WriteLine("Count is :"+count );
            Console.WriteLine("1: search operation ");
            Console.WriteLine("2 :Remove ");
            Console.WriteLine("3 :Show ");
            Console.WriteLine("4 :PopPosition");
            Console.WriteLine ("5 :Pop ");
            Console.WriteLine("6 :Index ");
            Console.WriteLine("7 :Insert position");
            Console.Write("Enter an option :");
            int option = int .Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    bool a = q.Search(7);
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine("Enter the Element to be removed :");
                    q.Remove(int.Parse(Console.ReadLine()));
                    q.Show();
                    break;
                case 3:
                    q.Show();
                    break;
                case 4:
                    Console.WriteLine("Enter the position ");
                    Console.WriteLine("Before pop operation");
                    q.Show();
                    Console.Write("\n After pop operation :");
                    q.PopPosition(int.Parse(Console.ReadLine()));
                    q.Show();
                    break;
                case 5:
                    q.Show();
                    Console.WriteLine("\nAfter pop operation ");
                    q.Pop();
                    q.Show();
                    break;
                case 6:
                    Console.Write("Enter the number :");
                    Console.WriteLine ("at index  :"+q.Index(int.Parse(Console.ReadLine())));
                    break;
                case 7:
                    Console.Write("Enter the position and element number :");
                    int n = int.Parse(Console .ReadLine ());
                    int m = int.Parse(Console.ReadLine());
                    q.insertPos(n,m);
                    q.Show();
                    break;

                default :
                    break;
                   
            }




        }
    }
}
