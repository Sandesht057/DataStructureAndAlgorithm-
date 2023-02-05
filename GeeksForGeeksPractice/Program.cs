using GeeksForGeeksPractice.ArrayProblems;
using GeeksForGeeksPractice.GraphProblem;
using GeeksForGeeksPractice.GreedyApproach;
using GeeksForGeeksPractice.LinkedList;
using GeeksForGeeksPractice.StringRealtedProblem;
using System;
using System.Collections.Generic;

namespace GeeksForGeeksPractice
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //ReverseLinkedList reverseObj = new ReverseLinkedList();
            //reverseObj.CreateLinkedList();

            //RecursionInDetail rec = new RecursionInDetail();
            //rec.PrintValue(3);
            //Console.ReadLine();


            //InOrderTraversalWithoutRecursion inTraversal = new InOrderTraversalWithoutRecursion();
            //inTraversal.root = new Node(1);
            //inTraversal.root.left = new Node(2);
            //inTraversal.root.right = new Node(3);
            //inTraversal.root.left.left = new Node(4);
            //inTraversal.root.left.right = new Node(5);
            //inTraversal.InOrderTraversal();
            //


            //LevelOrderTraversalUsingQ lvlTraversalQ = new LevelOrderTraversalUsingQ();
            //lvlTraversalQ.root = new Node(1);
            //lvlTraversalQ.root.left = new Node(2);
            //lvlTraversalQ.root.right = new Node(3);
            //lvlTraversalQ.root.left.left = new Node(4);
            //lvlTraversalQ.root.left.right = new Node(5);
            //lvlTraversalQ.root.right.left = new Node(6);
            //lvlTraversalQ.root.left.left.left = new Node(7);
            //lvlTraversalQ.PrintLevelOrder();



            //LevelOrderTraversal lvlTraversal = new LevelOrderTraversal();
            //lvlTraversal.root = new Node(1);
            //lvlTraversal.root.left = new Node(2);
            //lvlTraversal.root.right = new Node(3);
            //lvlTraversal.root.left.left = new Node(4);
            //lvlTraversal.root.left.right = new Node(5);
            //lvlTraversal.root.right.left = new Node(6);
            //lvlTraversal.root.left.left.left = new Node(7);
            //lvlTraversal.PrintLevelOrder();


            //List<int> inputSubset = new List<int>();
            //PrintAllSubsetOfNaturalNumber findSubSet = new PrintAllSubsetOfNaturalNumber();
            //findSubSet.FindSubset(inputSubset,3);

            //TwoDArrayImplementaton twoArray = new TwoDArrayImplementaton();
            //twoArray.PrintTwoDArray();

            //PrintOfStringInReverse reverseOne = new PrintOfStringInReverse();
            //string reverseResult = reverseOne.PrintReverseStringIterativeApproach("abc");

            //PrintOfStringInReverse reverseRecursiveApproach = new PrintOfStringInReverse();
            //reverseRecursiveApproach.PrintReverseStringRecursiveApproach("abcd", 3);

            //FindTheFirstAndLastOccuranceOfGivenString result = new FindTheFirstAndLastOccuranceOfGivenString();
            //result.RecursiveApproach("ABCDEFGB",'B',0);


            //int[] inputArray = new int[] { 0, 1, 2,2,5, 3 };
            //CheckAnyArrayIsSortedStrictlyIncreasing result = new CheckAnyArrayIsSortedStrictlyIncreasing();
            //var resultSet =  result.RecursiveApproachCheck(inputArray, 0);

            //MoveAllXtoTheEndOfTheString inputObj = new MoveAllXtoTheEndOfTheString();
            //string res= inputObj.RecursiveApproach("ABXXXCDE", 0, "");

            //RemoveDuplicateInString duplicateRes = new RemoveDuplicateInString();
            //duplicateRes.RecursiveApproach("abcccdeefg",0,"");

            //PrintAllSubSequenceOfString subsequence = new PrintAllSubSequenceOfString();
            //subsequence.PrintSubSequence("abc","", 0);

            //PrintUniqueSubsequenceofString prn = new PrintUniqueSubsequenceofString();
            //prn.RecursiveApproach("aabc", 0, "");

            //PrintAllPermutationOfString permutationObj = new PrintAllPermutationOfString();
            //permutationObj.PrintPermutation("abc", "");


            //PrintAllPermutationOfString permutationObj = new PrintAllPermutationOfString();
            //permutationObj.PermutationOfStringIterativeApprovach("abc",0,2);

            //int[] nums = new int[] { 1, 1, 2 };
            //RemoveDuplicatFromArray removeDuplicateObj = new RemoveDuplicatFromArray();
            //removeDuplicateObj.RemoveDuplicate(nums);

            //int[] nums = new int[] { 7, 1, 5, 3, 6, 4 };
            //BestTimeToBusyAndSellStock stockObj = new BestTimeToBusyAndSellStock();
            //stockObj.MaxProfit(nums);

            //int[] nums = new int[] { 2, 1, 7, 15 };
            //_2SumProblem sum = new _2SumProblem();
            ////sum.FindSum(nums,9);
            //sum.UsingHashMap(nums,9);

            //int[] nums = new int[] { -1,0,1 ,2,-1,-4};
            //_3SumArrayProblem sum = new _3SumArrayProblem();
            //sum.ThreeSumArrayProblem(nums);

            //int[] startArray = new int[] { 50, 120, 200, 550, 700, 850 };
            //int[] departureArray = new int[] { 500, 550, 600, 700, 900, 1000 };

            //SolveMinimumPlatFormProblem obj = new SolveMinimumPlatFormProblem();
            //var result= obj.FindMiniMumPlatForm(startArray,departureArray);

            //BinaryTreeImplementation treeObj = new BinaryTreeImplementation();
            //Node root = treeObj.CreateBinaryTree();


            //Graphs Impleemtation

            //BreadthFirstSearch bfs = new BreadthFirstSearch(4);
            //bfs.AddEdge(0, 1);
            //bfs.AddEdge(0, 2);
            //bfs.AddEdge(1, 2);
            //bfs.AddEdge(2, 0);
            //bfs.AddEdge(2, 3);
            //bfs.AddEdge(3, 3);
            //var res = bfs.BFS(0);

            //CreateSinglyLinkedListWithThreeNode();

           // DeletionInLinkedList();

            RecursiveApproachReverseLinkedList();

            Console.ReadLine();
        }

        static  void  RecursiveApproachReverseLinkedList()
        {
            ReverseLinkedListInRecursiveApproach reverseLinkedListInRecursiveApproach = new ReverseLinkedListInRecursiveApproach();
            reverseLinkedListInRecursiveApproach.Push(20);
            reverseLinkedListInRecursiveApproach.Push(4);
            reverseLinkedListInRecursiveApproach.Push(15);
            reverseLinkedListInRecursiveApproach.Push(85);
            //reverseLinkedListInRecursiveApproach.Push(85);

            reverseLinkedListInRecursiveApproach.Reverse(reverseLinkedListInRecursiveApproach.head);
        }

        public void DepthFirstSearchInLinekdList()
        {
            DepthFirstSearch dfs = new DepthFirstSearch();
            LinkedList<int>[] list = new LinkedList<int>[7];
            for (int i = 0; i < 4; i++)
            {
                list[i] = new LinkedList<int>();
            }
            list[0].AddLast(1);
            list[0].AddLast(2);
            list[1].AddLast(2);
            list[2].AddLast(0);
            list[2].AddLast(3);
            list[3].AddLast(3);
            var res = dfs.dfsOfGraph(4, list);

        }

        public static void CreateSinglyLinkedListWithThreeNode()
        {
            NodeForSinglyLinkedList nodeForSinglyLinkedList = new NodeForSinglyLinkedList();
            nodeForSinglyLinkedList.head = new  NodeForSinglyLinkedList.NodeSL(1);

            NodeForSinglyLinkedList.NodeSL second = new NodeForSinglyLinkedList.NodeSL(2);
            NodeForSinglyLinkedList.NodeSL third = new NodeForSinglyLinkedList.NodeSL(3);
            NodeForSinglyLinkedList.NodeSL fourth = new NodeForSinglyLinkedList.NodeSL(4);
           

            nodeForSinglyLinkedList.head.next = second;
            second.next = third;
            third.next = fourth;
        }

        public static void DeletionInLinkedList()
        {
            DeletionInLinkedList delObj = new DeletionInLinkedList();
            delObj.PushNode(7);
            delObj.PushNode(1);
            delObj.PushNode(3);
            delObj.PushNode(2);
            delObj.DeleteNode(1);
        }

    }


}
