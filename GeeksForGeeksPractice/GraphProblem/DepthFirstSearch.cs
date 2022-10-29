using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.GraphProblem
{
    public class DepthFirstSearch
    {
        public List<int> dfsOfGraph(int V, LinkedList<int>[] adj)
        {

            List<int> dfsStore = new List<int>();
            bool[] visited = new bool[V];

            for (int i = 0; i < V; i++)
            {
                if (!visited[i])
                {
                    dfs(i, adj, visited, dfsStore);
                }
            }
            return dfsStore;
        }

        public void dfs(int node, LinkedList<int>[] ajd, bool[] visited,List<int> storeDfs)
        {

            visited[node] = true;
            storeDfs.Add(node);
            LinkedList<int> list = ajd[node];
            foreach (var item in list)
            {
                if (!visited[item])
                {
                    dfs(item, ajd, visited, storeDfs);
                }

            }

        }
    }
}
