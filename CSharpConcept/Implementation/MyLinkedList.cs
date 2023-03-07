using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept.Implementation
{
    public class MyLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data; 
                this.next = null;
            }
        }

        public Node head;

        public MyLinkedList(int data)
        {
            head = new Node(data);
        }

        public void TraverseNode(Node node)
        {
            if (node.next != null)
            {
                Console.Write(node.data + "->");
                TraverseNode(node.next);
            }
        }

        public void InsertNode(Node node, int data)
        {
            if (node.next != null)
            {
                InsertNode(node.next, data);
            }
            else
                node.next = new Node(data);
        }

        public void RemoveNode(Node node, int data)
        {
            if (node.next != null)
            {
                var prev_node = node;
                if (data == node.data)
                {
                    prev_node.next = node.next;
                }
            }
            else
            {
                if (node.next != null)
                    RemoveNode(node.next, data);
            }
        }
    }
}
