using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice
{
    public class Node
    {
        public int data;
        public  Node right, left;
        public Node(int item)
        {
            data = item;
            right = null;
            left = null;
            
        }
    }

    //class BinaryTreeImplementation
    //{

    //    public Node CreateBinaryTree()
    //    {
    //        Node newNode = new Node();
    //        Console.WriteLine("Please Enter the Data");
    //        int information = Convert.ToInt32(Console.ReadLine());

    //        if (information == -1)
    //        {
    //            return newNode;
    //        }
    //        newNode.data = information;
    //        Console.WriteLine("Please Enter the Left child");                      
    //        newNode.left = CreateBinaryTree();

    //        Console.WriteLine("Please Enter the Right child");            
    //        newNode.right = CreateBinaryTree();

    //        return newNode;
    //    }

    //}


}
