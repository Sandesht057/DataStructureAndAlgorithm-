using GeeksForGeeksPractice.ArrayProblems;
using GeeksForGeeksPractice.DynamicProgramming;
using GeeksForGeeksPractice.DynamicProgramming.DpOnSequence;
using GeeksForGeeksPractice.DynamicProgramming.DpOnStrings;
using GeeksForGeeksPractice.GraphProblem;
using GeeksForGeeksPractice.GreedyApproach;
using GeeksForGeeksPractice.LinkedList;
using GeeksForGeeksPractice.Recursion;
using GeeksForGeeksPractice.StringRealtedProblem;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Threading;

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




      //int[] subSet = new int[3];
      //PrintAllSubsetOfNaturalNumber findSubSet = new PrintAllSubsetOfNaturalNumber();
      //findSubSet.GenerateSubsets(subSet,0,3);




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

      // RecursiveApproachReverseLinkedList();


      // ReverseNodesInKGroup();

      //  ReverseNodesInKGroupIterative();
      //  MergeTwoSortedArray();
      //stairsProblems();

      //  PrintNameNTimesUsingRecursion(3);

      //  PrintLinearlyFrom1ToN(3);

      // PrintTermsOfNTo1(3);

      //  SumNNumbers();
      //  FactorialOfN();
      // ReverseArray();
      //CheckForPalindrome();
      // FibonacciNumber();
      // PrintAllSubSequences();

      // PrintAllSubSequencesSumIsK();
      //PrintAnySubSequenceSumIsK();
      //CountSubSequenceWithMatchSum();
      //FindCombination();
      // FindPermutationOfArray();
      //FindUniqueCombination();
      // SolveNQueensProblems();

      // SolveSudoku();

      //  ColoredGraph(3, 2);

      // PartitonPalindrome();

      // FindCombinationSum();
      //FindCombinationSumTwo();

      //RateInaMaze();
      //FindKthPermutationSequence();
      //FrogJumProblem();
      //FrogJumProblemByK();

      //MaximumSumofNonAdjacent();

      //var res= HouseOfRobber();

      //FindMaxFromArray();
      // FindMaxFromAll();

      // FindGridUniquePath();

      //FindMinimumPathSumInGrid();

      //FindMinimumPathSumINTrangle();
      // MaximumFallingPathSum();

      // NinjaAndHisFriends();

      // FindSubSetSum();

      //PartitionEquallSubSetSum();

      //CountSubSet();
      // CountPartationWithGivenSum();

      // KnapSackProblemSolution();
      //FindMinimumCoins();

      //CoinChangeProblem();
      //KnapSackWithInfiniteSupply();

      LongestCommonSubSeq();
      Console.ReadLine();
    }

    static void LongestCommonSubSeq()
    {
      string s1 = "lop"; string s2 = "plo";
      LongestCommonSebSequence lcs = new LongestCommonSebSequence();
      var res= lcs.LCS(s1,s2);
    }

    static void KnapSackWithInfiniteSupply()
    {
      int[] wt = new int[3] { 2, 4, 6 };
      int[] val = new int[3] { 50, 11, 13 };
      int n = wt.Length;
      int W = 10;
      KnapSackWithInfiniteSupply kswf = new KnapSackWithInfiniteSupply();
      var res= kswf.KnapSackInfiniteSupply(wt,val,W,n-1);
    }

    static void CoinChangeProblem()
    {
      int[] arr = new int[3] { 1, 2, 3 };
      int target = 5;
      CoinChangeTwo cct = new CoinChangeTwo();
      var res = cct.CountWaysToChangeUtil(arr,arr.Length-1,target);
    }

    static void FindMinimumCoins()
    {
      int[] arr = new int[3] { 1, 2, 3 };
      int T = 7;
      MinimumCoins mc = new MinimumCoins();
      var res=  mc.FindMinimumCoins(arr,7,arr.Length-1);
    }

    static void KnapSackProblemSolution()
    {
      int[] wt = new int[] { 1, 2, 4, 5 };
      int[] val = new int[] { 5,4,8,6 };
      int W = 5;
      int n = wt.Length;
      KnapSackProblem knp = new KnapSackProblem();
      var res=  knp.KnapSackSolution(wt,val,W,n-1);

    }

    static void CountPartationWithGivenSum()
    {
      int[]  arr=new int[4] {5,2,6,4 };
      int diff = 3;
      CountPartitionsWithGivenDifference cpd = new CountPartitionsWithGivenDifference();
      var res= cpd.CountPartitionWithDifference(arr,diff);

      var rs = cpd.findWays(arr,diff);
    }


    static void CountSubSet()
    {
      int[] arr = new int[] { 1, 2, 2, 3 };
      int k = 5;

      CountSubSetWithSumK csk = new CountSubSetWithSumK();
      //var res=  csk.CountSubSet(arr,arr.Length-1,k);

      var res1 = csk.CountSubSetMatchK(arr,k);

      var rk = csk.FindWays(arr,k);
    }

    static void PartitionEquallSubSetSum()
    {
      int[] arr = new int[] { 2, 3, 3, 3, 4, 5 };
      int n = arr.Length;

      PartitionEqualSubSetSum pes = new PartitionEqualSubSetSum();
      var res= pes.CanPartition(n,arr);

    }

    static void FindSubSetSum()
    {
      int[] arr = new int[4] { 1, 2, 3,4 };

      SubSetSumEqalltoTarget sbj = new SubSetSumEqalltoTarget();
      var res= sbj.FindSubSetSum(2,arr,5);

      int[][] dp = prepareTwoDdp(3, 6);
      var res1 = sbj.FindSubSetSumMemoization(2,arr,5,dp);

      var res3 = sbj.FindSubSetSumTabulation(4,arr,4);
    }
   

    static void NinjaAndHisFriends()
    {
      int[][] a = new int[][] {
                  new int[] { 2,3,1,2},
                  new int[] { 3,4,2,2},
                  new int[] { 5,6,3,5},
              };
      int n = a.Length;
      int m = a[0].Length;

      NinjaAndHisFriends nhf = new NinjaAndHisFriends();
      //var res=  nhf.NinjaAndHisFriend(a,0,0,m-1,n,m);



      int[][][] dp = new int[n][][];
      for (int i = 0; i < n; i++)
      {
        dp[i] = new int[m][];
        for (int j = 0; j < m; j++)
        {
          dp[i][j] = new int[m];

          for (int k = 0; k < m; k++)
          {
            dp[i][j][k] = -1;
          }
        }
      }

      var res2 = nhf.maximumColocolate(a, 0, 0, m - 1, n, m, dp);
    }

    static void MaximumFallingPathSum()
    {
      int[][] a = new int[][] {
                  new int[] { 1,2,10,4},
                  new int[] { 100,3,2,1},
                  new int[] { 1,1,20,2},
                   new int[]{ 1,2,2,1},
              };

      MaximumFallingPathSum mfp = new MaximumFallingPathSum();
     // var res=  mfp.FindMaxOfAll(a,4);
      int[][] dp = prepareTwoDdp(4, 4);

      var resMemo = mfp.FindMaxofallMemoization(a,4,dp);

      var resTwo = mfp.FindMaxofallMemoizationTwo(a, 4, dp);

      var rk = mfp.GetMaxPathSumTabulation(a);

    }

    static void FindMinimumPathSumINTrangle()
    {
      int[][] triangle = new int[][]
      {
          new int[] { 1 },
          new int[] { 2, 3 },
          new int[] { 3, 6, 7 },
          new int[] { 8, 9, 6, 10 }
      };
      int[][] dp = prepareTwoDdp(3, 3);
      MinimumPathsumInTrangularGrid fms = new MinimumPathsumInTrangularGrid();
      var res= fms.MinimumPathInTrangle(triangle,0,0,3,dp);
    }


     static void FindMinimumPathSumInGrid()
     {
          int n = 3;
          int[][] a = new int[][] {
                  new int[] { 10, 8, 2 },
                  new int[] { 10, 5, 100 },
                  new int[] { 1, 1, 2 }
              };
      int[][] dp = prepareTwoDdp(3,3);
      MinimumPathSumInGrid mps = new MinimumPathSumInGrid();
      int res= mps.FindMinimumSumUniquePath(a,2,2);

      int res1 = mps.FindMinimumSumUniquePathTabulation(a, 2, 2,dp);

    }

    static int[][]  prepareTwoDdp(int m, int n)
    {

      int[][] a = new int[m][];
      for (int i = 0; i < m; i++)
      {
        a[i] = new int[n];
        for (int j = 0; j < n; j++)
        {
          a[i][j] = -1;
        }
      }
      return a;
    }


    static void FindGridUniquePath()
    {
      int m = 3, n = 2;

      int[][] a = new int[m][];
      for (int i = 0; i < m; i++)
      {
        a[i] = new int[n];
        for (int j = 0; j < n; j++)
        {
          a[i][j] = -1;
        }
      }
      GridUniquePath fup = new GridUniquePath();
      var res=  fup.FindGridUniquePath(a,m-1,n-1);
    }
    static void FindMaxFromAll()
    {
      int n = 3;
      int[][] a = new int[][] {
              new int[] { 10, 40, 70 },
              new int[] { 20, 50, 80 },
              new int[] { 30, 60, 90 }
          };

      int[][] a1 = new int[][] {
              new int[] { 10, 40, 70 },
              new int[] { 20, 50, 80 }
          };

      MaximumNoOfMeritNinjaEarn max = new MaximumNoOfMeritNinjaEarn();
      //var res = max.FindFromall(a,3);

      //var res2 = max.MaxiMumNoOfMeritNinjaEarn(2,3,a);

      var res3 = max.MaxiMumNoOfMeritNinjaEarn(1, 3, a1);
    }

    static void FindMaxFromArray()
    {
      int[] arr = new int[5] { 10, 20, 40, 5,60 };
      MaximumNoOfMeritNinjaEarn max = new MaximumNoOfMeritNinjaEarn();
      var res= max.FindMaximumFromArray(arr.Length-1,arr);
    }

      static  void MaximumSumofNonAdjacent()
      {
        //int[] arr =new int[4]{2,1,4,9 };
      int[] arr = new int[5] { 2, 1, 4, 9, 6 };

      int[] arr1 = new int[4] { 2, 1, 4, 9};
      MaximumSumOfNonAdjacentElementt sum = new MaximumSumOfNonAdjacentElementt();
        var res= sum.MaiximumSumOfNonAdjacent(arr1, arr1.Length - 1);
      }


    static int HouseOfRobber()
    {
      int[] temp1 = new int[3];
      int[] temp2 = new int[3];

      int[] arr1 = new int[4] { 2, 1, 4, 9 };

      int x=0, y=0;
      for (int i = 0; i < arr1.Length; i++)
      {
        if (i > 0)
        {
          temp1[x] = arr1[i];
          x++;
        }

        if (i < arr1.Length - 1)
        {
          temp2[y] = arr1[i];
          y++;
        }
      }

      MaximumSumOfNonAdjacentElementt sum = new MaximumSumOfNonAdjacentElementt();
      var res = sum.MaiximumSumOfNonAdjacent(temp1, temp1.Length-1);
      var res1 = sum.MaiximumSumOfNonAdjacent(temp2, temp2.Length-1);
      return Math.Max(res, res1);
    }




    static void FrogJumProblem()
      {
        int[] arr = new int[6] { 30, 10, 60, 10, 60, 50 };

        FrogCanJumTwoWaysFindMinimunEnergy fgj = new FrogCanJumTwoWaysFindMinimunEnergy();
        var res=  fgj.FindMinimumEnergy(5,arr);

        int[] dp = Enumerable.Repeat(-1, 6).ToArray();
        var resmomization = fgj.FindMinimumEnergyMemoization(5, arr,dp);

        var resTabulation = fgj.FindMinimumEnergyTabulation(5, arr,dp);
      }

      static void FrogJumProblemByK()
      {
        int[] arr = new int[6] { 30, 10, 60, 10, 60, 50 };

        FrogCanJumpKSteps fcj = new FrogCanJumpKSteps();
        var minEng=  fcj.FindMinimumEnergyWithKStep(5,arr,2);
      }


    static void FindKthPermutationSequence()
    {
      int n = 3, k = 3;
      string s = "";
      List<string> res = new List<string>();
      for (int i = 1; i <= n; i++)
      {
        s += i;
      }

      FindKthPermutationSequence perObj = new FindKthPermutationSequence();
      perObj.FindPermutaion(s.ToCharArray(),0,res);

    }


      static void RateInaMaze()
      {

        int n = 4;
        int[][] a = new int[][] {
              new int[] { 1, 0, 0, 0 },
              new int[] { 1, 1, 0, 1 },
              new int[] { 1, 1, 0, 0 },
              new int[] { 0, 1, 1, 1 }
          };

        int[][] vis = new int[n][];
        for (int i = 0; i < n; i++)
        {
          vis[i] = new int[n];
          for (int j = 0; j < n; j++)
          {
            vis[i][j] = 0;
          }
        }

        List<string> res = new List<string>();
        RateInaMaze rt = new RateInaMaze();
       // rt.FindPath(0, 0, 4,"",res, a, vis);


      int[] di = new int[] { +1, 0, 0, -1 };
      int[] dj = new int[] { 0, -1, +1, 0 };

       rt.FindPathV2(0, 0, 4, di, dj, "", a, vis, res);
      }

      static void FindCombinationSumTwo()
    {
      List<List<int>> ans = new List<List<int>>();
      List<int> ds = new List<int>();

      int[] array = new int[] { 2, 5, 2, 1, 2 };
      int target = 5;
      Array.Sort(array);
      CombinationSumII res = new CombinationSumII();
      res.FindAllUniqueCombination(array,0,target,ds,ans);

     //res.FindCombinations(0,array,target,ans,ds);

    }

      static void FindCombinationSum()
      {
        List<int> set = new List<int>();
        List<List<int>> result = new List<List<int>>();

       
        int[] inputValue = new int[7] { 10, 1, 2, 7, 6, 1, 5 };
        int[] subSet = new int[7];
        CombinationSum findSubSet = new CombinationSum();


        findSubSet.FindCombinationSum(inputValue,subSet, 8, 0);
        findSubSet.FindCombinationSumTakeOwn(inputValue, set, 8, 0, result);
      }


     static void PartitonPalindrome()
     {
        List<string> path = new List<string>();
        List<List<string>> res = new List<List<string>>();
        string s = "aabb";
      string hel = "hello";
      string re = hel.Substring(0, 2);

        PalindromePartitioning pobj = new PalindromePartitioning();
        pobj.Solution(s, 0, path, res);
     } 

    static void ColoredGraph(int N, int M)
    {
      List<int>[]  graph = new List<int>[N];
      for (int i = 0; i < N; i++)
      {
        graph[i] = new List<int>();
      }

      graph[0].Add(1);
      graph[1].Add(0);

      graph[1].Add(2);
      graph[2].Add(1);

      graph[0].Add(2);
      graph[2].Add(0);

      //graph[3].Add(0);
      //graph[0].Add(3);
      //graph[0].Add(2);
      //graph[2].Add(0);

      GraphColoring cgp = new GraphColoring();
      int[] color = new int[N]; 
      var res=  cgp.ColoredGivenGraph(graph,color,M);

    }

      static void SolveSudoku()
      {
        char[][] board = new char[][] {
                   new char[]    {'9', '5', '7', '.', '1', '3', '.', '8', '4'},
                   new char[]    {'4', '8', '3', '.', '5', '7', '1', '.', '6'},
                   new char[]    {'.', '1', '2', '.', '4', '9', '5', '3', '7'},
                   new char[]    {'1', '7', '.', '3', '.', '4', '9', '.', '2'},
                   new char[]    {'5', '.', '4', '9', '7', '.', '3', '6', '.'},
                   new char[]    {'3', '.', '9', '5', '.', '8', '7', '.', '1'},
                   new char[]    {'8', '4', '5', '7', '9', '.', '6', '1', '3'},
                   new char[]    {'.', '9', '1', '.', '3', '6', '.', '7', '5'},
                   new char[]    {'7', '.', '6', '1', '8', '5', '4', '.', '9'}
                 };
        SudokuSolve sudokuSolve = new SudokuSolve();
        sudokuSolve.SolveSudoku(board);

        for (int i = 0; i < 9; i++)
        {
          for (int j = 0; j < 9; j++)
          {
            Console.WriteLine(board[i][j] + " ");
          }
            Console.WriteLine();
        }

      }


     static void SolveNQueensProblems()
    {
      NQueensProblems nq = new NQueensProblems();
      var res = nq.SolveNQueens(4);

    }
        static void ReverseArray()
        {
          ReverseArray arObj = new ReverseArray();
          int[] arr = new[] { 0, 2, 3, 4 }; 
          var res=  arObj.ReverseArrayUsingRecursion(arr,0,arr.Length-1);
        }

        static void FindPermutationOfArray()
        {
          PermutationOfStringOrArray perm = new PermutationOfStringOrArray();
          int[] arr = new[] { 1,2,3 };
          bool[] freq = new[] { false, false, false };
          List<int> ds = new List<int>();
          List<List<int>> ans = new List<List<int>>();
          //perm.RecurPermutation(arr,ds,ans,freq);
          perm.RecurPermutationBySwapping(arr, 0,ans);
        // perm.RecurPermute(0, arr, ans);
        }

    static void FindUniqueCombination()
    {
      FindUniqueCombination fwd = new FindUniqueCombination();
      int[] arr = new int[] { 1,1,1,2,2 };
      List<int> ds = new List<int>();
      List<List<int>> ans = new List<List<int>>();
      fwd.findUniqueCombo(0,arr, 4, ans, ds);
    }



    static void FindCombination()
        {
          FindCombinationWithDuplicateValue fwd = new FindCombinationWithDuplicateValue();
          int[] arr = new int[] { 2, 3,6,7 };
          List<int> ds = new List<int>();
          List<List<int>> ans = new List<List<int>>();
          fwd.FindCombination(arr,0,7,ans,ds);
        }

        static void FibonacciNumber()
    {
      FibonacciNumber fbn = new FibonacciNumber();
      Console.WriteLine(fbn.PrintFibonacci(4));
    }

    static void CountSubSequenceWithMatchSum()
    {
      CountTheSubSequenceWithSumK csm = new CountTheSubSequenceWithSumK();
      int[] arr = new int[] { 3, 1, 2, 1 };
      List<int> list = new List<int>();
      var res =  csm.CountTheSubSequence(arr,arr.Length,0,0,5,list);
    }

    static void PrintAnySubSequenceSumIsK()
    {
      PrintSubSequenceWhoseSumIsSum subSum = new PrintSubSequenceWhoseSumIsSum();
      int[] arr = new int[] { 3, 1, 2, 1 };
      List<int> list = new List<int>();
      subSum.PirntSubSumIsSum(arr,0,0,5,arr.Length,list);
    }


    static void PrintAllSubSequencesSumIsK()
    {
      PrintingSubSequencesWhoseSumIsK sbu = new PrintingSubSequencesWhoseSumIsK();
      int[] arr = new int[] { 3, 1, 2,1 };
      List<int> list = new List<int>();
      sbu.PrintSubK(arr,  0, arr.Length,0,5, list);
    }

    static void PrintAllSubSequences()
    {
      PrintAllSubSequences sbu = new PrintAllSubSequences();
      int[] arr = new int[] { 3, 1, 2 };
      List<int> list = new List<int>();
      
      sbu.PrintSubsequence(arr,arr.Length,0,list);
    }

        static void CheckForPalindrome()
    {
      int[] arr = new int[] {0, 1, 2, 3, 3, 1,0 };
      CheckIfGivenStringIsPalindromeOrnot cs = new CheckIfGivenStringIsPalindromeOrnot();
     var res= cs.IsPalindrome(arr,0);
    }

        static void PrintNameNTimesUsingRecursion(int N)
        {
          PrintNameNTimes pnObj = new PrintNameNTimes();
          pnObj.PrintName(N);
        }

        static void FactorialOfN()
        {
          FactorialOfN snm = new FactorialOfN();
          var res = snm.FindFactorial(4);
        }

        static void SumNNumbers()
        {
          SumOfTheFirstNNumbers snm = new SumOfTheFirstNNumbers();
          var res =  snm.SumValueAnotherApproach(3);
        }


      static void PrintTermsOfNTo1(int N)
      {
      PrintInTermsOfNto1 pnObj = new PrintInTermsOfNto1();
        //pnObj.PrintNumber(N);
        pnObj.PrintNumber(3, 1);
      }


    static void PrintLinearlyFrom1ToN(int N)
        {
          PrintLienarllyFrom1toN pnObj = new PrintLienarllyFrom1toN();
          //pnObj.PrintNumber(N);
          pnObj.PrintNumberSecondApproach(1, 3);
        }

    static void stairsProblems()
        {
          PossibleStairsJumpsProblem obj = new PossibleStairsJumpsProblem();
          var res=  obj.FindOutMaximumPossibleWayToClimbStairs(3);
        }

        static  void  RecursiveApproachReverseLinkedList()
        {
            ReverseLinkedListInRecursiveApproach reverseLinkedListInRecursiveApproach = new ReverseLinkedListInRecursiveApproach();
            reverseLinkedListInRecursiveApproach.Push(20);

            reverseLinkedListInRecursiveApproach.Push(4);
            //reverseLinkedListInRecursiveApproach.Push(15);
            //reverseLinkedListInRecursiveApproach.Push(85);
            //reverseLinkedListInRecursiveApproach.Push(85);

            reverseLinkedListInRecursiveApproach.Reverse(reverseLinkedListInRecursiveApproach.head);
        }

        static void ReverseNodesInKGroup()
        {
          ReverseTheLinkedListNodeInKGroup reverseNodesInKGroup = new ReverseTheLinkedListNodeInKGroup();
          reverseNodesInKGroup.Push(20);
          reverseNodesInKGroup.Push(4);
          reverseNodesInKGroup.Push(15);
          reverseNodesInKGroup.Push(85);
      //  reverseNodesInKGroup.Push(10);
         var res=  reverseNodesInKGroup.RerverseInKGroup(reverseNodesInKGroup.head,2);

        }


        static void MergeTwoSortedArray()
        {
          MergeTheSortedLinkedList firstNode = new MergeTheSortedLinkedList();
          firstNode.Push(5);
          firstNode.Push(4);
          firstNode.Push(1);

          MergeTheSortedLinkedList secondNode = new MergeTheSortedLinkedList();
          secondNode.Push(15);
          secondNode.Push(8);
          secondNode.Push(6);

         var res = secondNode.MergeSortedLinkedListRecursiveApproach(firstNode.head, secondNode.head);

        }



    static void ReverseNodesInKGroupIterative()
    {
      ReverseNodeInKGroupIterativeApprovach reverseNodesInKGroup = new ReverseNodeInKGroupIterativeApprovach();
      reverseNodesInKGroup.Push(20);
      reverseNodesInKGroup.Push(4);
      reverseNodesInKGroup.Push(15);
      reverseNodesInKGroup.Push(85);
      //  reverseNodesInKGroup.Push(10);
      var res = reverseNodesInKGroup.RerverseInKGroup(reverseNodesInKGroup.head, 2);

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
