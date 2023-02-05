using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.LinkedList
{
    public class DeletionInLinkedList
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

        public void  PushNode(int new_data)
        {
            Node newNode = new Node(new_data);
            newNode.next = head;
            head = newNode;
        }

        public void DeleteNode(int key)
        {
            Node temp = head;
            Node prev = null;

            if(key==temp.data && temp != null)
            {
                head = temp.next;
                return;
            }

            while (key!=temp.data && temp!=null)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            prev.next = temp.next;

        }


    }
}
