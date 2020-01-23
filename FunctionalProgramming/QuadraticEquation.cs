using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class QuadraticEquation
    {
        public static void   quadraticEquation()
        {
            double root1, root2;
            Console.WriteLine("Enter the quadreatic equation value (a,b,c)");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double delta = (b*b)-(4 * a * c);
            if (delta>0) {
                 root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                 root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("First root is :" + root1);
                Console.WriteLine("Second root is :" + root2);
            }
            else if (delta == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("Root1==Root2 :"+root1);
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("root1 ="+ realPart+" im"+ imaginaryPart+"root2 :"+ realPart+" im"+ imaginaryPart);
            }
        }
    }
}
