using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  internal class RateInaMaze
  {

    public void FindPathV2(int i, int j,  int n,int[] di,int[] dj,string move, int[][] a,int[][] vis,List<string>res   )
    {

      if(i == n-1 && j == n - 1)
      {
        res.Add(move);
        return;
      }

      string dir = "DLRU";
      for(int ind=0; ind<4; ind++)
      {

        int nexti = i + di[ind];
        int nextj = j + dj[ind];

        if(nexti >=0 && nextj >=0 && nexti <n && nextj <n && vis[nexti][nextj] ==0 && a[nexti][nextj] == 1)
        {
          vis[i][j] = 1;
          FindPathV2(nexti, nextj, n, di, dj, move + dir[ind], a, vis, res);
          vis[i][j] = 0;
        }
      }
    }

    private static void Solve(int i, int j, int[][] a, int n, List<string> ans, string move,
                          int[][] vis, int[] di, int[] dj)
    {
      if (i == n - 1 && j == n - 1)
      {
        ans.Add(move);
        return;
      }

      string dir = "DLRU";
      for (int ind = 0; ind < 4; ind++)
      {
        int nexti = i + di[ind];
        int nextj = j + dj[ind];
        if (nexti >= 0 && nextj >= 0 && nexti < n && nextj < n &&
            vis[nexti][nextj] == 0 && a[nexti][nextj] == 1)
        {
          vis[i][j] = 1;
          Solve(nexti, nextj, a, n, ans, move + dir[ind], vis, di, dj);
          vis[i][j] = 0;
        }
      }
    }

    public void FindPath(int i, int j,int n, string path,List<string> res, int[][] adj, int[][] visited)
    {

      if(i==n-1 && j == n-1)
      {
        res.Add(path);
        return;
      }

      //down
      if(i+1<n && adj[i + 1][j] ==1 && visited[i + 1][j] == 0)
      {
        visited[i][j] = 1;
        FindPath(i + 1, j, n, path+"D", res, adj, visited);
        visited[i][j] = 0;

      }

      //left
      if (j-1 >=0 && adj[i][j-1] == 1 && visited[i][j-1] == 0)
      {
        visited[i][j] = 1;
        FindPath(i, j-1, n, path+"L", res, adj, visited);
        visited[i][j] = 0;

      }

      //right
      if (j + 1 < n && adj[i][j + 1] == 1 && visited[i][j + 1] == 0)
      {
        visited[i][j] = 1;
        FindPath(i, j + 1, n, path+"R", res, adj, visited);
        visited[i][j] = 0;
      }

      //up
      if (i - 1 >=0  && adj[i - 1][j] == 1 && visited[i - 1][j] == 0)
      {
        visited[i][j] = 1;
        FindPath(i - 1, j, n, path+"U", res, adj, visited);
        visited[i][j] = 0;

      }

    }

  }
}
