using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GeeksForGeeksPractice.LinkedList
{
  public class ReverseLinkedListInRecursiveApproach
  {
    public  Node head;
    public class Node
    {
      public int data;
      public Node nextNode;
      public Node(int d)
      {
         data = d;

      }
    }

    public void Push(int data)
    {
      Node temp = new Node(data);
      temp.nextNode = head;
      head = temp;
    }

    public  Node Reverse(Node head)
    {
        if(head ==null || head.nextNode == null)
        {
            return head;
        }

      Node rest = Reverse(head.nextNode);
      head.nextNode.nextNode = head;
      head.nextNode = null;
      return rest;

    }



  }


}
