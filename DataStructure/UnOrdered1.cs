using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
   public class UnOrdered1<T>

    {
        private Node head;
        private int count;
        public UnOrdered1()
        {
            this.head = null;
            this.count = 0;
        }
        public bool Empty
        {
            get { return this.count == 0; }
        }
        public void Add(T a)

        {
            Node n = head;
            Node temp = new Node(a);
            if (n == null)

            {
                head = temp;
            }
            else
            {
                while (n.next != null)

                {
                    n = n.next;
                }
                n.next = temp;
            }
            count++;
        }
        public bool isEmpty()
        {
            return count == 0;
        }
        public int Size()
        {
            return this.count;
        }
        public bool Search(T b)

        {
            Node current = this.head;
            while (current != null)

            {
                if (current.data.Equals(b))
                {
                    return true;

                }
                current = current.next;
            }
            return false
            ;

        }
        public void Show()
        {
            Node current = this.head;
            while (current != null)

            {
                Console.Write(current.data+" ");
                current = current.next;
            }
        }
        public void Remove(T c)

        {
            Node current = this.head;
            Node prev = null
            ;

            if (current.data.Equals(c))
            {
                head = current.next;
            }
            else
            {
                while (!current.data.Equals(c))
                {
                    prev = current;
                    current = current.next;
                }
                prev.next = current.next;
                current = current.next;
            }
            count--;
        }
        public int Index(T b)

        {
            Node current = this.head;
            int position = 0;
            while (current != null)

            {
                if (current.data.Equals(b))
                {
                    return position;
                }
                position++;
                current = current.next;


            }
            return -1;
        }
        public void PopPosition(int pos)
        {
            // Console.WriteLine();
            int i = 1;
            Node current = this.head;
            if (pos == 1)
            {
                this.head = current.next;

            }
            else if( pos <= count)
            {
                while (i < pos - 1 )
                {
                    current = current.next;
                    i++;
                }
                if (current.next.Equals(null))
                {
                    current = null;
                }
                else
                {
                    current.next = current.next.next;
                }

            }
            Console.WriteLine("You have entered wrong position ");
        }
            
           public  void Pop()
            {              
                Node current = this.head;
                if (current == null)
                {
                    //this.head = current.next;
                    Console.WriteLine("No element");
                }
                else if (current.next.Equals(null))
                   {
                    current = null;
                   }
                else if (!(current.next).Equals(null)) 
                {
                    while (!(current.next).Equals(null))
                    {
                        current = current.next;

                    }

                    current = null;

                 

                }


            }
        
    }
}
    
