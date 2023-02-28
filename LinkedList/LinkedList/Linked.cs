using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Linked
    {
        public Node head;

        //Add method for UC1
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            { 
                this.head = node;
            }
            else 
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} inserted into linked list ", node.data);
            }            
        }

        //For display method
        public void Display()
        {
            Node temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            Console.WriteLine("LinkedList is :");
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }

        //for reverse method UC2
        public void Reverse(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine(newNode.data + "is inserted into the linked list");            
        }

        //for Remove first node for method UC3
        public void RemoveFirstNode()
        {           
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                this.head = this.head.next;
                Console.WriteLine("LinkedList first element is deleted");
            }           
        }


        //for last node for Method UC4
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node lastNode = this.head;
                while (lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("LinkedList last element is deleted");
            }
        }

        public void SerchValue(int data)
        {
            bool doesExist = false;
            if(head !=null)
            {
                int count = 0;
                Node temp = head;
                while (temp != null) 
                {
                    if(temp.data == data)
                    {
                        doesExist = true;
                        count++;
                    }
                    temp = temp.next;
                }
                if (doesExist)
                {
                    Console.WriteLine("{0} data >>>>> count {1}", data,count);
                }
                else
                {
                    Console.WriteLine(data + " is not present into the LinkedList");
                }
            }           
        }
        public void Size()
        {
            Node temp = head;
            int count = 0;
            if(temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data +"");
                temp = temp.next;
                count++;
            }
            Console.WriteLine(count);

        }
    }
}

