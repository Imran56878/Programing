using System;
using System.Threading;
namespace ThreadPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : ThreadTest");
            Console.WriteLine("2 : FullTimeEmployee ");
            Console.Write("Enter your choice :");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ThreadTest t = new ThreadTest();
                    t.Test();
                    break;

                case 2:
                    FullTimeEmployee fte = new FullTimeEmployee()
                    {
                        Id = 101,
                        fName = "Mark",
                        lName = "May",
                        annualSalary = 6000
                    };
                    Console.WriteLine("Full Name :"+fte.GetFullName());
                    Console.WriteLine("Monthly Salary :"+fte.Monthlysalary());
                    break;

                default:
                    break;

            }



        }


    }
}
