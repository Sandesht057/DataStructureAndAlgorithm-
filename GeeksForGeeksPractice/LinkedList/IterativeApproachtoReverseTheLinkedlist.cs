using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.LinkedList
{
  public class IterativeApproachtoReverseTheLinkedlist
  {
    public Node head;

    public class Node
    {
      public int data;
      public Node nextNode;

      public Node(int data)
      {
        this.data = data;
        this.nextNode = null;
      }
    }

    void Push(int data)
    {
      Node temp = new Node(data);
      temp.nextNode = head;
      head = temp;
    }

    Node ReverseTheLinkedList(Node head)
    {
      if(head == null)
      {
        return head;
      }
      Node previous = null, current = head, next = head.nextNode;
      while(current != null)
      {
        current.nextNode = previous;
        previous = current;
        current = next;

        if (next.nextNode != null)
        {

          next = next.nextNode;
        }
      }
      return previous;

    }
  }


}
