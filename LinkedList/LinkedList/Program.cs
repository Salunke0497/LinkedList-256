using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linked linked = new Linked(); //object LinkedList
            LinkedLIstStack stack = new LinkedLIstStack(); //Object for stack and queue
            Console.WriteLine("choose one : ");
            Console.WriteLine("1)Add LinkedList\n2)Reverse LinkedList\n3)Remove First Node From LinkedList\n4)Remove Last Node From LinkedList\n5)Search data\n6)Size of LinkedList\n7)Display LinkedList\n8)push value into stack\n9)exit");
            int option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        linked.Add(56);
                        linked.Add(30);   //for add method 
                        linked.Add(70);   //UC1
                        break;

                    case 2:
                        linked.Reverse(70);
                        linked.Reverse(30); // for reverse method
                        linked.Reverse(56); //UC2
                        break;
                    case 3:
                        linked.Add(56);
                        linked.Add(30); //fpr remove first node method 
                        linked.Add(70); //UC3
                        linked.RemoveFirstNode();
                        break;
                    case 4:
                        linked.Add(56);
                        linked.Add(30); // for remove last node method
                        linked.Add(70); //UC4
                        linked.RemoveLastNode();
                        linked.Display();
                        break;
                    case 5:
                        linked.SerchValue(70);  //for serch value
                        linked.Display();       //UC5
                        break;
                    case 6:
                        linked.Add(56);
                        linked.Add(30);    //for checking the size of LinkedList
                        linked.Add(70);   //UC6
                        linked.Size();
                        break;
                    case 7:
                        linked.Display(); // for display the linked list
                        break;
                    default:
                            break;
                }
                Console.ReadLine();
        }
    }
}
