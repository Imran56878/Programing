using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class ReplaceString
    {
        public static void Replace()
        {
            string name = "Hello <<UserName>> , how are you ?";
            Console.WriteLine("Enter name to be replaced ");
            string replaceName = Utility.readString();
            string replace = name.Replace("<<UserName>>",replaceName);
            Console.WriteLine(replace);
        }
    }
}
