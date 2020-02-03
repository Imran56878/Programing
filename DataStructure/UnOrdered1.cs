using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class UnOrdered1
    {
        int m = 0;
        Node next = null;
        public void Print(int data)
        {
            Node temp = null;
            Console.WriteLine("|" + data + "|->");
            if (next != null)
            {
                data = next.data;
                next = temp.next;
                Print(data);
            }
          
        }
        
    }
}
