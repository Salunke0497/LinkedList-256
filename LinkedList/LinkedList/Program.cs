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
            Linked linked = new Linked();
            bool flag = true;
            Console.WriteLine("choose one : ");
            int option = Convert.ToInt32(Console.ReadLine());
           
            while (flag)
                switch (option)
                {
                    case 1:
                         linked.Add(56);
                         linked.Add(30);
                         linked.Add(70);
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        break;
                }
        }
        }
    }
}
