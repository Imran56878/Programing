using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Node
    {
        public object   data;
        public Node next;
        public Node prev;
        public Node head;
        public Node(object num)
        {
            data = num;
            next = null;
           
            
        }
      }
}
