using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.SingleLinkedList
{
    internal class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {
            int n, i, data;
            Console.WriteLine("Enter number of nodes to create: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid number of nodes.");
                return;
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter data for node " + (i + 1) + ": ");
                data = Convert.ToInt32(Console.ReadLine());
                Node newNode = new Node(data);
                if (start == null)
                {
                    start = newNode;
                }
                else
                {
                    Node p = start;
                    while (p.link != null)
                    {
                        p = p.link;
                    }
                    p.link = newNode;
                }
            }
        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty ... ");
                return;
            }
            Console.WriteLine("List is : ");
            p = start;
            while (p != null)
            {
                Console.WriteLine(p.info + "  ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool SearchNode(int x)
        {
            Node p = start;
            int pos = 1;
            while (p != null)
            {
                if (p.info == x)
                {
                    Console.WriteLine("Element " + x + " found at position " + pos);
                    return true;
                }
                p = p.link;
                pos++;
            }
            Console.WriteLine("Element " + x + " not found in the list.");
            return false;
        }
    }
}
