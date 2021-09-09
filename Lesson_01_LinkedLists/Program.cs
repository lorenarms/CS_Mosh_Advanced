using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_LinkedLists
{
    class LinkedList
    {
        private Node _head;

        public class Node
        {
            private int _data;
            private string _firstName;
            private string _lastName;
            private Node _next;

            //constructor to create new node
            public Node(int d)
            {
                _data = d;
                _firstName = null;
                _lastName = null;
                _next = null;
            }
            public Node(int d, string fullName)
            {
                string[] names = fullName.Split(' ');           //split the first and last name into separate items
                _data = d;
                _firstName = names[0];
                _lastName = names[1];
                _next = null;

            }
            public void SetNextNode(Node node)
            {
                this._next = node;
            }
            public int GetData()
            {
                return this._data;
            }
            public Node GetNode()
            {
                return this._next;
            }
            public string GetName()
            {
                string name = this._lastName + ", " + this._firstName;
                return name;
            }
            public void PrintInfo()
            {
                Console.WriteLine("Name: " + this.GetName() + "  Data: " + this.GetData());
            }
        }

        public void Push(int new_data, string new_name)
        {
            Node new_node = new Node(new_data, new_name);
            new_node.SetNextNode(_head);
            _head = new_node;
        }

        public void SetHead(Node node)
        {
            this._head = node;       //sets the passed node to 'head'
        }
        public Node GetHead()
        {
            return _head;            //returns the head of the list
        }

        public void PrintList()
        {
            Node n = _head;
            while (n != null)
            {
                Console.WriteLine("Name: " + n.GetName() + "  Data: " + n.GetData());
                n = n.GetNode();
            }
        }
}
    class Program
    {
        
        static void Main(string[] args)
        {
            var llist = new LinkedList();           //create a list object
            llist.SetHead(new LinkedList.Node(1, "Lawrence Artl"));  //set where the start of the list is
            
            var second = new LinkedList.Node(2, "Angelina Dominguez");    //create a second list item
            var third = new LinkedList.Node(3, "Trinity Day");     //create a third list item

            llist.GetHead().SetNextNode(second);    //set the head's 'next' pointer to 'second'
            second.SetNextNode(third);              //set the second's 'next' pointer to 'third'

            llist.Push(4, "Sofia Dominguez");                          //create a new list node and push it to the front of the list

            llist.PrintList();                      //print the list

            Console.ReadKey();

            

        }
    }
}
