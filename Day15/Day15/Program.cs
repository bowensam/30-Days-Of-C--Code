using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    class Node
    {
        public int data;
        public Node next;

        public Node (int d)
        {
            data = d;
            next = null;
        }
    }

    class Solution
    {
        public static Node Insert (Node head, int data)
        {
            if (head == null) //Initial case: No nodes, instantiate the first node with data
                head = new Node(data);
            else if (head.next != null) //Navigate down the linked list until the final node is reached
                Insert(head.next, data);
            else
            { //At the tail of the final node, add a reference to a new node containing a new piece of data
                Node nextNode = new Node(data);
                head.next = nextNode;
            }
            return head; //return the entire linked list to the calling block in Main
        }
        
        public static void Display (Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
            Console.WriteLine();
        }

        static void Main (String[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }
            Display(head);
        }
    }
}
