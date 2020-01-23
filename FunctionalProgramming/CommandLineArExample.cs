using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class CommandLineArExample
    {
        public static void CmdExample(string []str)
        {
            foreach(string s in str)
            {
                Console.Write(" "+s);
            }
        }
    }
}
