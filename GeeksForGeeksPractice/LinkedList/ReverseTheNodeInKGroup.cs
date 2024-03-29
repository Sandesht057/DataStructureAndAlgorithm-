using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.LinkedList
{
  public class ReverseTheLinkedListNodeInKGroup
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

    public  void Push(int data)
    {
      Node temp = new Node(data);
      temp.nextNode = head;
      head = temp;
    }


    public Node RerverseInKGroup(Node head,int k)
    {
      if(head==null || head.nextNode == null || k == 1)
      {
        return head;
      }
      Node start = head, end = head;
      int inc = k - 1;
      while(inc>0)
      {
        end = end.nextNode;
        if(end == null)
        {
          return head;
        }
        inc--;          
      }
      Node nextHead = RerverseInKGroup(end.nextNode, k);
      ReverseOwn(start, end);
      start.nextNode = nextHead;
      return end;
    }

    Node ReverseOwn(Node start, Node end)
    {

      Node previous = null, current = start, next = start.nextNode;
      while(previous != end)
      {
        current.nextNode = previous;
        previous = current;
        current = next;
        while(next != null)
        {
          next = next.nextNode;
        }
      }
      return previous;

    }


  }




}
