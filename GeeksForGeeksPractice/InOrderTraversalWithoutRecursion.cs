using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice
{
    public class InOrderTraversalWithoutRecursion
    {
        public Node root;

             
        public void InOrderTraversal()
        {
            if(root == null)
            {
                return;
            }

            Stack<Node> s = new Stack<Node>();
            Node current = root;

            while(current !=null || s.Count > 0)
            {
                while(current != null)
                {
                    s.Push(current);
                    current = current.left;
                }

                current = s.Pop();
                Console.WriteLine("Current Data" + current.data);
                current = current.right;
            }

        }
    }


}
