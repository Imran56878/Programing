using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BankingCash <T>
    {
        public int count = 0;
        Node head = null;
        public void Queue()
        {
             
        }
        public void enqoueue(T item )
        {
            Node current = head;
            Node temp = new Node(item);
            if (current ==null )
            {
               
                head = temp;
                count++;
            }
            else
            {
                while(current .next !=null)
                {
                    current = current.next;
                }
               // Node temp1 = new Node(item);
                current.next = temp;
                count++;

            }

        }
        public void Show()
        {
            Console.WriteLine("Customer List :");
            Node current = head;
            while (current!=null) 
            {
              
                Console.WriteLine(current.data);
                current = current.next;
            }
           
        }
        public void dequeue()
        {
            Node current = head;
            if (isEmpty ()==true)
            {
                Console.WriteLine("Queue is empty");
                //return ;
            }
           else if (count==1)
            {
                //current = null;
                head = null;
                count--;
            }
            else
            {
                head = current.next;
                current = null;
                count--;
            }

        }
        public bool isEmpty()
        {
            if (count==0)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {

            return count;
        }

    }
}
