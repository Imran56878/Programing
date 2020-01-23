using FunctionalProgramming.JunitTestingProgram;
using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Replace String ");
            Console.WriteLine("2: Flip coin ");
            Console.WriteLine("3: Leap year ");
            Console.WriteLine("4: Power of 2 ");
            Console.WriteLine("5: Season validity ");
            Console.WriteLine("6: Harmonic series");
            Console.WriteLine("7: Prime factor of the number");
            Console.WriteLine("8: Sum of three number");
            Console.WriteLine("9: Euclidean distance");
            Console.WriteLine("10: Quadratic equation");
            Console.WriteLine("11: Gambler program");
            Console.WriteLine("12: 2Darray");
            Console.WriteLine("13: N Distinct Coupon");
            Console.WriteLine("14: Wind chill");
            Console.WriteLine("15: Stopwatch");
            Console.WriteLine("16: Tic.Tac.Toe ");
            Console.WriteLine("17: Wending Machine ");
            Console.WriteLine("18: Newton's square root of non negative number ");
            Console.WriteLine("19: fib ");
            Console.WriteLine("20: Temprature conversion");
            Console.WriteLine("21: Binary String");
            Console.Write("Enter an option to execute : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ReplaceString.Replace();
                    break;
                case 2:
                    flipCoin.FlipCoin();
                    break;
                case 3:
                    LeapYear.leapYear();
                    break;
                case 4:
                    Power.powerSeries();
                    break;
                case 5:
                    SpringSeason.springSeason();
                    break;
                case 6:
                    Harmonic.harmonicNumber();
                    break;
                case 7:
                    PrimeFactor.primeFactor();
                    break;
                case 8:
                    ThreeNumber.threeNumber();
                    break;
                case 9:
                    Distance.distance();
                   break;
                case 10:
                    QuadraticEquation.quadraticEquation();
                    break;
                case 11:
                    Gambler.GamblerCheck();
                    break;
                case 12:
                    {
                        MultiDimensionalArray.ArraymultiDimension();
                        MultiDimensionalArray.getArray();
                    }
                    break;
                case 13:
                    {
                        Coupon.CouponA();
                    }
                    break;
                case 14:
                    WindChill.windChill();
                    break;
                case 15:
                    StopDemo.stopDemo();
                    break;
                case 16:
                    TicTacToe.ticTacToe();
                    break;
                case 17:
                    VendingMachine.jUnit();
                    break;
                case 18:
                    NewtonSqrt.newtonSqrt();
                    break;
                case 19:
                    FiboSeriese.fib();
                    break;
                case 20:
                    TempratureConversion.tempC();
                    TempratureConversion.tempF();
                    break;
                case 21:
                    ToBinaryString.toBinary();
                    break;

                default:
                    Console.WriteLine("you have entered wrong choice");
                    break;
            }

        }
    }
}
