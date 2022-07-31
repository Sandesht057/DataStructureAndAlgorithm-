using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice
{
    public class LevelOrderTraversal
    {
        public Node root;
        public void PrintLevelOrder()
        {
            int h = FindOutTheHeightOfTheTree(root);
            int i;
            for (i=1; i<=h; i++)
            {
                PrintCurrentLevel(root, i);
            }

        }

        public int FindOutTheHeightOfTheTree(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                int LeftHeight = FindOutTheHeightOfTheTree(root.left);
                int RightHeight = FindOutTheHeightOfTheTree(root.right);

                if (LeftHeight > RightHeight)
                {
                    return (LeftHeight+1);
                }
                else
                {
                    return (RightHeight+1);
                }
            }
        }

        public void PrintCurrentLevel(Node root,int Level)
        {
            if(root == null)
            {
                return;
            }

            if(Level == 1)
            {
                Console.WriteLine(root.data);
            }
            else
            {
                PrintCurrentLevel(root.left, Level - 1);
                PrintCurrentLevel(root.right, Level - 1);
            }
        }

    }
}
