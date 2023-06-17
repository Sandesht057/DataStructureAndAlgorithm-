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
  public class MergeTheSortedLinkedList
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


    public Node MergeTwoSortedLinkedList(Node first,Node second)
    {
      if(first ==null)
      {
        return second;
      }

      if(second == null)
      {
        return first;
      }

      if(first.data < second.data)
      {
        first.nextNode = MergeTwoSortedLinkedList(first.nextNode, second);
        return first;
      }
      else
      {
        second.nextNode = MergeTwoSortedLinkedList(second.nextNode, first);
        return second;
      }
    }

    public Node MergeSortedLinkedListRecursiveApproach(Node first, Node second)
    {
        if(first == null) { return second; }
        if (second == null) { return first; }
        Node ans = null,tail=null;

        if (first.data < second.data)
        {
          ans = first;
          tail = first;
          first = first.nextNode;
        }
        else
        {
          ans = second;
          tail = second;
          second = second.nextNode;
        }

        while (first !=null && second !=null)
        {
            if(first.data < second.data)
            {
              tail.nextNode = first;
              tail = first;
              first = first.nextNode;
            }
            else
            {
              tail.nextNode= second;
              tail = second;
              second= second.nextNode;
            }

        }

      if (first == null)
      {
        tail.nextNode = second;
      }
      else
      {
        tail.nextNode = first;
      }

      return ans;

    }


  }




}
