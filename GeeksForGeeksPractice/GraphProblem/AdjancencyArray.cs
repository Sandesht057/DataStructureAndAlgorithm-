using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.GraphProblem
{
    public class AdjancencyArray
    {

        //using Adjacency Matrxi

        public int[,]  PrintGraph()
        {
            int m = 3, n = 3;
            int[,] adj = new int[n + 1,n+1];

            //Edge 1--2
            adj[1, 2] = 1;
            adj[2, 1] = 1;

            //Edge 2--3
            adj[2, 3] = 1;
            adj[3, 2] = 1;

            //Edge 1--3
            adj[1, 3] = 1;
            adj[3, 1] = 1;
            return adj;
        }


        public int[,] PrintGraph(int U, int V)
        {
            int m = 3, n = 3;
            int[,] adj = new int[n + 1, n + 1];

            for (int i = 0; i < V; i++)
            {
                adj[U, V] = 1;
                adj[V, U] = 1;
            }
   
            return adj;
        }

        //Using Adjacency List

        public void PrintGraphUsingAdjList()
        {
            int m=3, n=3;
            List<List<int>> adj = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int>());

                //Edge 1--2
                adj[1][2] = 1;
                adj[2][1] = 1;


                //Edge 1--3
                adj[1][3] = 1;
                adj[3][1] = 1;

                //Ege 2--3
                adj[2][3] = 1;
                adj[3][2] = 1;

            }
        }


        public void PrintGraphUsingAdjList(int u, int v)
        {
            int m = 3, n = 3;
            List<List<int>> adj = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int>());

                //Edge 1--2
                adj[u][v] = 1;
                adj[v][u] = 1;
            }
        }


    }
}
