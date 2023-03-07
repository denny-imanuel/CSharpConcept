using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept.Implementation
{
    public class MyBinaryTree
    {
        public class Node
        {
            public int data;
            public Node? left;
            public Node? right;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public Node? root;
        public MyBinaryTree(int data)
        {
            this.root = new Node(data);
        }

        public Node InsertNode(Node? node, int data)
        {
            if (node != null)
            {
                if (data < node.data)
                    node.left = InsertNode(node.left, data);
                if (data > node.data)
                    node.right = InsertNode(node.right, data);
                return node;
            }
            else
                return new Node(data);
        }

        public void RemoveNode(Node? node, int data)
        {
            if (node != null)
            {
                if (data < node.data)
                    RemoveNode(node.left, data);
                if (data > node.data)
                    RemoveNode(node.right, data);
            }
        }


        public void DfsPreOrder(Node? node)
        {
            // node -> left -> right
            if (node != null)
            {
                Console.Write(node.data + "->");
                DfsPreOrder(node.left);
                DfsPreOrder(node.right);
            }
        }

        public void DfsInOrder(Node? node)
        {
            // left -> node -> right
            if (node != null)
            {
                DfsInOrder(node.left);
                Console.Write(node.data + "->");
                DfsInOrder(node.right);
            }
        }

        public void DfsPostOrder(Node? node)
        {
            // left -> right -> node
            if (node != null)
            {
                DfsPostOrder(node.left);
                DfsPostOrder(node.right);
                Console.Write(node.data + "->");
            }
        }

        public void BfsUsingStack(Node? node)
        {
            var stack = new Stack<Node>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                var last = stack.Pop();
                Console.Write(last.data + "->");
                if (last.left != null)
                    stack.Push(last.left);
                if (last.right != null)
                    stack.Push(last.right);
            }
        }

        public void BfsUsingQueue(Node? node)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var last = queue.Dequeue();
                Console.Write(last.data + "->");
                if (last.left != null)
                    queue.Enqueue(last.left);
                if (last.right != null)
                    queue.Enqueue(last.right);
            }
        }
    }
}
