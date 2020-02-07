using System;
using System.Threading;
namespace ThreadPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ThreadTest t = new ThreadTest();
            t.Test();
        }

       
    }
}
