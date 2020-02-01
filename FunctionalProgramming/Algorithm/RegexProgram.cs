using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FunctionalProgramming.Algorithm
{
    class RegexProgram
    {
        public static void RegularEx()
        {
            Console.WriteLine("Enter your full name ");
            string fname = Utility.readString();
            string mob = Utility.readString();
            string db = Utility.readString();
            string[] lname = fname.Split();
            Console.WriteLine("First name:"+lname[0]);
            Console.WriteLine("Full name:"+fname );
            string str = "Hello <<name>> , We have your full name as <<fullname>> in our system . Your contact number is " +
                         "91-xxxxxxxxxx . Please let me know in case of any clarification . Thank you BridgeLabz 01/01/2016";
            // string m = str.Replace("<<name>>",lname [0]);
            /*string input = "This is   text with   far  too   much   " +
               "white space.";
            string pattern = "\\s+";
            string replacement = " ";
            string result = Regex.Replace(input, pattern, replacement); */
            //[@&'(\\s)<>#]
           
            str = Regex.Replace(str, "[<>name]{7,8}", lname[0]);
            str = Regex.Replace(str, "[<>fulname]{9,}", fname);
            str = Regex.Replace(str, "[x]{2,12}", mob);
            str = Regex.Replace(str,"01/01/2016", db);
            Console.WriteLine(str);
        }
    }
}
