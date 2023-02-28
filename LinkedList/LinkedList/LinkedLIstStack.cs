using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{    
    public class LinkedLIstStack
    {
        public Node top;        
        public LinkedLIstStack()
        {
            this.top = top;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
                if(this.top == null)
                {
                    node.next = null;
                }
                else
                {
                    node.next = this.top;                 
                }
                this.top = node;
                Console.WriteLine(value);
        }
        public void Displaystack()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("stack is empty ");
            }
            Console.WriteLine("Stack is : ");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine(" Stack is empty ");
                return;
            }
            Console.WriteLine("Value Poped is {0}", this.top.data);
            this.top = this.top.next;

        }
    }
}
