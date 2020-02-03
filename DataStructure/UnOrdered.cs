using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
    class UnOrdered
    {
        public static void SearchWord()
        {
            int m = 0;
            string path = @"E:\\pro\TestBin.txt";
            string str = File.ReadAllText(path);
            string[] arr = str.Split(" ");
           List<string> lk = new List<string>();
            for (int i =0;i<arr.Length;i++) { 
            lk.Add(arr[i]);
            }
            Console.WriteLine("Enter a string to search");
            string word = Console.ReadLine();
            for (int  j=0;j<lk.Count;j++)
            {
                if (lk[j].Equals(word))
                {
                     lk.RemoveAt(j);
                    m = 0;
                    break;
                }
                else m = 1;
               
            }
            if (m == 1)
            {
                lk.Add(word );
            }
            Console.Write("OUtput :");
            foreach (string a in lk)
            {
                Console.Write(a+" ");
            }

        }
    }
}
