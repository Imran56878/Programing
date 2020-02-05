using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
   public class UnOrdered1<T>

    {
        public  Node head;
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
            return false ;

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
            Node prev = null;

            if (current.data.Equals(c))
            {
                head = current.next;
                count--;
            }
            else
            {
                while (current != null)
                {
                    if (!current.data.Equals(c))
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
            int i = 1;
            Node current = this.head;
            if (pos == 1)
            {
                this.head = current.next;
                count--;

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
                    count--;
                }
                else
                {
                    current.next = current.next.next;
                    count--;
                }

            }
          //  Console.WriteLine("You have entered wrong position ");
        }
             public void insertPos(int pos ,T   item)
         {
            Node current = this.head;
            Node prev=null;
            int i = 1;
            Node temp = new Node(item);
            if (pos<=count)
            {
              
            
                while (i<pos)

                {
                    prev = current;
                    current  = current .next;
                    i++;
                
                }
                    temp.next = current;
                prev.next = temp;
                count++;
            }
            
            
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
                    while (current.next.next !=(null))
                    {
                        current = current.next;

                    }

                    current.next = null;

                 

                }


            }
        
    }
}
    
