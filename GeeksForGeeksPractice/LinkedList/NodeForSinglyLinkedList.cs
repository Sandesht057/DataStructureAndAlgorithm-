using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.LinkedList
{
    public class NodeForSinglyLinkedList
    {
        public  NodeSL head;
        public  class NodeSL
        {
            public  int data;
            public NodeSL next;
            public NodeSL(int d)
            {
                data = d;
                next = null;
            }
        }
    }

    public class LinkedNode
    {
        public int data;
        public LinkedNode next;
        public LinkedNode(int d)
        {
            data = d;
            next = null;
        }
    }



}
