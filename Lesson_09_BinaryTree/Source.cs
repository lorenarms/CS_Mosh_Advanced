using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_09_BinaryTree
{
    public class Tree
    {
        public class Node
        {
            public int key;
            public Node left;
            public Node right;
        }
        private Node _root;

        public Node GetRoot()
        {
            return this._root;
        }

        public Tree()
        {
            _root = null;
        }

        ~Tree()
        {
            
        }

        public void Add(int key)
        {
            var curr = new Node();
            var toAdd = new Node();

            toAdd.key = key;
            toAdd.left = toAdd.right = null;

            if (this._root == null)
            {
                this._root = toAdd;
                return;
            }
            else
            {
                curr = this._root;
                while (curr != null)
                {
                    if(toAdd.key < curr.key)
                    {
                        if(curr.left == null)
                        {
                            curr.left = toAdd;
                            return;
                        }
                        else
                        {
                            curr = curr.left;
                        }
                    }
                    else
                    {
                        if(curr.right == null)
                        {
                            curr.right = toAdd;
                            return;
                        }
                        else
                        {
                            curr = curr.right;
                        }
                    }
                }
            }
            
        }

        public void PrintTree(Node curr)
        {
            if (curr == null)
            {
                return;
            }

            PrintTree(curr.left);
            if(curr.left == null && curr.right == null)
            {
                Console.WriteLine("00 <-L- " + curr.key + " -R-> 00");
            }
            else if (curr.left != null && curr.right == null)
            {
                Console.WriteLine(curr.left.key + " <-L- " + curr.key + " -R-> 00");
            }
            else if (curr.left == null && curr.right != null)
            {
               Console.WriteLine("00 <-L- " + curr.key + " -R-> " + curr.right.key);
            }
            else if (curr.left != null && curr.right != null)
            {
                Console.WriteLine(curr.left.key + " <-L- " + curr.key + " -R-> " + curr.right.key);
            }
                PrintTree(curr.right);
        }

        public void Remove(Node curr, int key)
        {
            //Node parent = null;
            var parent = new Node();
            parent = null;
            //Console.WriteLine("Current node: " + curr.key);
            //Console.WriteLine("Parent node: " + parent.key);


            while (curr != null)
            {
                if (curr.key == key)
                {
                    if (curr.left == null && curr.right == null)
                    {
                        if (parent == null)
                        {
                            this._root = null;
                        }
                        else if (parent.left == curr)
                        {
                            parent.left = null;
                        }
                        else
                        {
                            parent.right = null;
                        }
                    }
                    else if (curr.left != null && curr.right == null)
                    {
                        if (parent == null)
                        {
                            this._root = curr.left;
                        }
                        else if (parent.left == curr)
                        {
                            parent.left = curr.left;
                        }
                        else
                        {
                            parent.right = curr.left;
                        }
                    }
                    else if (curr.left == null && curr.right != null)
                    {
                        if (parent == null)
                        {
                            this._root = curr.right;
                        }
                        else if (parent.left == curr)
                        {
                            parent.left = curr.right;
                        }
                        else
                        {
                            
                            parent.right = curr.right;
                        }
                    }
                    else
                    {
                        Node succ = null;
                        succ = curr.right;
                        while (succ.left != null)
                        {
                            succ = succ.left;
                        }
                        curr.key = succ.key;

                        Remove(curr.right, succ.key);
                    }
                    return;
                }
                else if (curr.key < key)
                {
                    parent = curr;
                    curr = curr.right;
                }
                else
                {
                    parent = curr;
                    curr = curr.left;
                }

            }
            return;
        }  
    }
    class Source
    {
        public static void Main(string[] args)
        {
            var tree = new Tree();
            tree.Add(5);
            tree.Add(7);
            tree.Add(6);
            tree.Add(8);
            tree.Add(3);
            tree.Add(2);
            tree.Add(4);

            tree.PrintTree(tree.GetRoot());
            Console.WriteLine("Root: " + tree.GetRoot().key + "\n");
            Console.ReadKey();

            tree.Remove(tree.GetRoot(), 8);
            tree.PrintTree(tree.GetRoot());
            Console.WriteLine("Root: " + tree.GetRoot().key + "\n");
            Console.ReadKey();


            tree.Remove(tree.GetRoot(), 6);
            tree.PrintTree(tree.GetRoot());
            Console.WriteLine("Root: " + tree.GetRoot().key + "\n");

            Console.ReadKey();

        }
    }
}
