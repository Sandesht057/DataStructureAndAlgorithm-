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
  public class ReverseNodeInKGroupIterativeApprovach
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

      Node dummyNode = new Node(-1);
      dummyNode.nextNode = head;
      Node beforeStart = dummyNode, end = head;

      int inc =0;
      while(end !=null)
      {
        inc++;
        if(inc%k==0)
        {
          Node start = beforeStart.nextNode;
          Node temp = end.nextNode;
          ReverseOwn(start, end);

          beforeStart.nextNode = end;
          start.nextNode = temp;

          beforeStart = start;
          end = temp;
        }
        else
        {
          end = end.nextNode;
        }
      }

      return dummyNode.nextNode;

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
