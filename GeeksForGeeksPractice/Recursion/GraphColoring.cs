using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class GraphColoring
  {
    public Boolean ColoredGivenGraph(List<int>[] graph, int[] color,int m)
    {

      int n = graph.Length;
      if (Solve(graph, color, n, m, 0))
      {
        return true;
      }
      return false;
    }

    public Boolean IsSafe(List<int>[] adj,int color, int[] colors,int node)
    {
      foreach (var item in adj[node])
      {
        if (colors[item] == color) return false;
      }
      return true;
    }


    public Boolean Solve(List<int>[] graph, int[] colors,int n, int m, int node)
    {

      if (node ==n)
      {
        return true;
      }

      for (int i=1; i<=m; i++)
      {
        if (IsSafe(graph, i, colors, node))
        {
          colors[i] = i;
          if (Solve(graph, colors, n, m, node + 1))
          {
            return true;
          }
          colors[i] = 0;
        }
      }
      return false;
    }


  }

  class Solve
  {
    bool IsSafe(int v, bool[,] graph, int[] color, int c, int V)
    {
      for (int i = 0; i < V; i++)
      {
        if (graph[v, i] && c == color[i])
        {
          return false;
        }
      }

      // returning true if no connected node has same colour.
      return true;
    }

    bool GraphColoringUtil(bool[,] graph, int m, int[] color, int v, int V)
    {
      // if all vertices have been assigned colour then we return true.
      if (v == V)
      {
        return true;
      }

      for (int c = 1; c <= m; c++)
      {
        // checking if this colour can be given to a particular node.
        if (IsSafe(v, graph, color, c, V))
        {
          // assigning colour to the node.
          color[v] = c;

          // calling function recursively and checking if other nodes
          // can be assigned other colours.
          if (GraphColoringUtil(graph, m, color, v + 1, V) == true)
          {
            // returning true if the current allocation was successful.
            return true;
          }

          // if not true, we backtrack and remove the colour for that
          // node.
          color[v] = 0;
        }
      }
      // if no colour can be assigned, we return false.
      return false;
    }

    // Function to determine if graph can be coloured with at most M colours
    // such
    // that no two adjacent vertices of graph are coloured with same colour.
    bool GraphColoring(bool[,] graph, int m, int n)
    {
      int[] color = new int[n];
      for (int i = 0; i < n; i++)
      {
        color[i] = 0;
      }

      // checking if colours can be assigned.
      if (GraphColoringUtil(graph, m, color, 0, n) == false)
      {
        return false;
      }

      return true;
    }
  }



}

