using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice
{
    public class LevelOrderTraversalUsingQ
    {
        public Node root;

        public void PrintLevelOrder()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                Node dequeNode = queue.Dequeue();
                Console.WriteLine(dequeNode.data);

                if(dequeNode.left != null)
                {
                    queue.Enqueue(dequeNode.left);
                }

                if(dequeNode.right != null)
                {
                    queue.Enqueue(dequeNode.right);
                }
            }
        }

    }
}
