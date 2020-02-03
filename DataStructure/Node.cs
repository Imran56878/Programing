using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Node
    {
        public int  data;
        public Node next;
        public Node prev;
        public Node head;
        UnOrdered1 ud = new UnOrdered1();
        public Node(int num)
        {
            data = num;
            next = null;
            prev = null;
            head = null;
            ud.Print(data );
        }
      }
}
