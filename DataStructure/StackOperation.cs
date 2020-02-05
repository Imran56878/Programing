using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
   public class StackOperation<T>
    {
        Node top;
        int count;
        public StackOperation()
        {
            this.count = 0;
            this.top = null;
        }
        public void push(T a)
        {
            Node temp = new Node(a);
            temp.next = top;
            top= temp;


        }
        public void pop( )
        {
            if (top==null )
            {
                Console.WriteLine(" Stack is underflow ");
                return;
            }
            top = top.next;
        }
        public void display()
        {
            Node temp = top;
            while (temp!=null)
            {
                Console.WriteLine(temp.data );
                temp = temp.next;
            }
           
        }
        public bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else return false;
        }
        public T  peek()
        {
            // check for empty stack  
            if (!isEmpty())
            {
                return (T)top.data;
            }
            else
            {
                //Console.WriteLine("Stack is empty");
                throw new System.NotImplementedException("Stack is Empty");
            }

        }
    }
}
