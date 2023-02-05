using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.LinkedList
{
    public class FindTheMiddleOfTheLinkedList
    {
        Node head;
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

        void push(int data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            head = newNode;
        }


        Node FindTheMiddleNode(Node head)
        {
            int n = 0;
            Node temp = head;
            while(temp != null)
            {
                n++;
                temp = temp.next;
            }

            int half = n / 2;
            temp = head;

            while (half--==0)
            {
                temp = temp.next;
            }
            return temp;
        }

    }
}
