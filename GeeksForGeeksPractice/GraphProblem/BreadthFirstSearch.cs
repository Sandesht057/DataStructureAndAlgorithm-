using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeeksForGeeksPractice.GraphProblem
{
    public  class BreadthFirstSearch
    {

        private int _V;

        LinkedList<int>[] _adjList;
        List<int> bfsList=new List<int>();
        public BreadthFirstSearch(int V)
        {

            _adjList = new LinkedList<int>[V];
            
            for (int i = 0; i < _adjList.Length; i++)
            {
                _adjList[i] = new LinkedList<int>();
            }
            _V = V;
        }


        public void AddEdge(int V,int W)
        {
            _adjList[V].AddLast(W);
        }

        public List<int> BFS(int s)
        {
            bool[] visited = new bool[_V];

            for (int i = 0; i < _V; i++)
            {
                visited[i] = false;
            }
            LinkedList<int> queue = new LinkedList<int>();
            visited[s] = true ;
            queue.AddLast(s);

            while (queue.Any())
            {
                s = queue.First();
                bfsList.Add(s);
                queue.RemoveFirst();

                LinkedList<int> list = _adjList[s];
                foreach (var item in list)
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        queue.AddLast(item);
                    }
                }
            }
            return bfsList;

        }


        public List<int> BFSForComponentGraph(int v,List<int>[] adj)
        {
            List<int> bfs = new List<int>();
            bool[] visited = new bool[v];

            for (int i = 0; i < v; i++)
            {
                if (!visited[i])
                {
                    Queue<int> queue = new Queue<int>();
                    queue.Enqueue(i);
                    visited[i] = true;

                    while (queue.Count>0)
                    {
                        bfs.Add(i);
                        queue.Dequeue();
                        List<int> list = adj[i];
                        foreach (var item in list)
                        {
                            if (!visited[item])
                            {
                                visited[item] = true;
                                queue.Enqueue(item);
                            }

                        }
                    }
                }
            }
            return bfs;
        }



    }


}
