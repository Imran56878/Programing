using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class DeQueue<T>
    {
        int count;
        public Node front=null;
        public Node rear=null;
        public void dequeue()
        {

        }
        public void addFront(T item)
        {
            //Node current = front;
            Node temp = new Node(item );
            if (front==null)
            {
                front = temp;
                rear = temp;
              
            }
            else
            {
                temp.next = front;
                front = temp;
            }
            count++;

        }
        public void addRear(T item)
        {
            Node temp = new Node(item);
            Node current = front;
            if (rear==null)
            {
                 front = temp;
                rear = temp;
            }
            else
            {
                rear.next = temp;
                rear = temp;
            }
            count++;
        }
      public T removeFront()
        {
            if (front!=null)
            {
                T a = (T)front.data;
                front = front.next;
                count--;
                return a;
            }
            throw new  NotImplementedException("Dequeue is empty");
        }
       public T removeRear()
        {
            if (rear==null)
            {
                throw new NotImplementedException("Dequeue is empty");
            }
            else
            { Node current = front;
                while (current .next!=null)
                {
                    current = current.next;
                }
               T b= (T)rear.data;
                rear = current;
                rear.next = null;
                count--;
                return b;
            }
             ;
        }
        public int Size()
        {

            return count;
        }
        public bool isEmpty()
        {

            return count==0;
        }
        public void Show()
        {
            Console.WriteLine("Customer List :");
            Node current = front ;
            while (current != null)
            {

                Console.WriteLine(current.data);
                current = current.next;
            }

        }
    }
}
