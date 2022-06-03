using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tree
{
    public class Binarytree
    {
        public Node root;
        public Binarytree()
        {
            root = null;
        }
        public Binarytree(int value)
        {
            root = new Node(value);
        }
        public void preOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine("   value:" + node.value);
                preOrder(node.left);
                preOrder(node.right);
            }
        }
        public void postOrder(Node node)
        {
            if (node != null)
            {
                postOrder(node.left);
                postOrder(node.right);
                Console.WriteLine("   value:" + node.value);
            }
        }
        public void inOrder(Node node)
        {
            if (node != null)
            {
                inOrder(node.left);
                Console.WriteLine("   value:" + node.value);
                inOrder(node.right);
            }
        }
        public void insert(Node newNode)
        {
            Node temp = root;
            Node x = null;
            while (temp != null)
            {
                x = temp;
                if (newNode.value < temp.value)
                    temp = temp.left;
                else
                    temp = temp.right;
            }
            if (x == null)
                root = newNode;
            if (newNode.value < x.value)
                x.left = newNode;
            else
                x.right = newNode;
        }
    }
    public class Node
    {
        public int value;
        public Node left, right;
        public Node(int value)
        {
            left = right = null;
            this.value = value;
        }
        public Node()
        {
            left = right = null;
        }
    }
}

/*
                 1
                2  3
               4  5
(a) Inorder (Left, Root, Right) : 4 2 5 1 3 
(b) Preorder (Root, Left, Right) : 1 2 4 5 3 
(c) Postorder (Left, Right, Root) : 4 5 2 3 1
*/