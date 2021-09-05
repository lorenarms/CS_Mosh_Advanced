using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_LinkedLists
{
    class LinkedList
    {
        private Node head;

        public class Node
        {
            private int data;
            private Node next;

            //constructor to create new node
            public Node(int d)
            {
                data = d;
                next = null;
            }
            public void SetNextNode(Node node)
            {
                this.next = node;
            }
            public int GetData()
            {
                return this.data;
            }
            public Node GetNode()
            {
                return this.next;
            }
        }

        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.SetNextNode(head);
            head = new_node;
        }

        public void SetHead(Node node)
        {
            this.head = node;
            //if (node == this.head)
            //{
                
            //}
            
        }
        public Node GetHead()
        {
            return head;
        }

        

        public void PrintList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.GetData() + " ");
                n = n.GetNode();
            }
        }

        

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var llist = new LinkedList();

            llist.SetHead(new LinkedList.Node(1));
            
            
            var second = new LinkedList.Node(2);
            var third = new LinkedList.Node(3);

            llist.GetHead().SetNextNode(second);
            second.SetNextNode(third);

            llist.PrintList();

            llist.Push(4);

            Console.WriteLine();

            llist.PrintList();

            Console.ReadKey();
            
        }
    }
}
