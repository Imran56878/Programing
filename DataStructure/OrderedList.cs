using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class OrderedList <T> where T:IComparable 
    {
        public Node head;
        private int count;
        public OrderedList()
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
            Node current = head;
            Node temp = new Node(a);
            Node prev = null;
            if (current == null)
            {
                head = temp;
               
            }
            else
            {
                T d1 = (T)current.data;
                T d2 = a;
                if (d1.CompareTo(d2)>=0)
                {
                    temp.next = current;
                    head = temp;
                }
                else
                {
                    while(current.next!=null && d2.CompareTo(d1) > 0)
                    {
                        prev = current;
                        current = current.next;
                        d1 = (T)current.data;
                    }
                    if (d1.CompareTo(d2) >= 0)
                    {
                        prev.next = temp;
                        temp.next = current;
                    }
                    else
                    {
                        current.next = temp;
                    }
                }
            }
            count++;
        }
    
        public void Show()
        {
            Node current = this.head;
            while (current != null)

            {
                Console.Write(current.data + " ");
                current = current.next;
            }
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
            return false ;

        }
        public void Remove(T c)

        {
            Node current = this.head;
            Node prev = null;

            if (current.data.Equals(c))
            {
                head = current.next;
                count--;
            }
            else
            {
                while ( current !=null )
                {
                    if (!current.data .Equals (c))
                    {
                        prev = current;
                        current = current.next;
                    }
                   
                
                 else if (current.data.Equals(c))
                 {
                    prev.next = current.next;
                    current = current.next;
                        count--;
                 }
                else
                 {
                        current = current.next;
                     
                 }
                }
            }
           // Console.WriteLine("Wrong value");
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
                count--;

            }
            else if (pos <= count)
            {
                while (i < pos - 1)
                {
                    current = current.next;
                    i++;
                }
                if (current.next.Equals(null))
                {
                    current = null;
                    count--;
                }
                else
                {
                    current.next = current.next.next;
                    count--;
                }

            }
           
            Console.WriteLine("You have entered wrong position... ");
        }
        public int Size()
        {
            return this.count;
        }
    }
}
