using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class NQueensProblems
  {
      public List<List<string>> SolveNQueens(int n)
      {
        List<List<string>> result = new List<List<string>>();
        char[][] board = new char[n][];
        for (int i = 0; i < n; i++)
        {
          board[i] = new char[n]; 
          for (int j = 0; j < n; j++)
          {
            board[i][j] = '.';
          }
        }
        Solve(0, board, result, n);
        return result;
      }

    public List<List<string>> SolveNQueensUsingHasing(int n)
    {
      List<List<string>> result = new List<List<string>>();
      char[][] board = new char[n][];

      int[] leftRow = new int[n];
      int[] upperDiagnoal = new int[2*n-1];
      int[] lowerDiagnoal = new int[2*n-1];

      for (int i = 0; i < n; i++)
      {
        board[i] = new char[n];
        for (int j = 0; j < n; j++)
        {
          board[i][j] = '.';
        }
      }
      SolveUsingHasing(0,leftRow,upperDiagnoal,lowerDiagnoal,  board, result);
      return result;
    }

    public void SolveUsingHasing(int col, int[] leftRow, int[] upperDiagnoal, int[] lowerDiagnoal, char[][] board,List<List<string>>res)
    {

      if (col == board.Length)
      {
        res.Add(Construct(board));
        return;
      }

      for(int row=0; row<board.Length; row++)
      {
        if (leftRow[row] == 0 && lowerDiagnoal[row+col] ==0 && upperDiagnoal[board.Length - 1 + col - row] == 0)
        {
          board[row][col] = 'Q';
          leftRow[row] = 1;
          lowerDiagnoal[row + col] = 1;
          upperDiagnoal[board.Length - 1 + col - row] = 1;
          SolveUsingHasing(col + 1, leftRow, upperDiagnoal, lowerDiagnoal, board, res);
          board[row][col] = '.';
          leftRow[row] = 0;
          lowerDiagnoal[row + col] = 0;
          upperDiagnoal[board.Length - 1 + col - row] = 0;
        }
      }
    }

    public List<string> Construct(char[][] board)
    {
          List<string> res = new List<string>();
          for (int i = 0; i < board.Length; i++)
          {
            string s = new string(board[i]);
            res.Add(s);
          }
          return res;
    }




    public void Solve(int col, char[][]board,List<List<string>>res,int n) 
    {
        if (col == n)
        {
          res.Add(Construct(board));
          return;
        }

      for (int row = 0; row < n; row++)
      {
        if (IsSafe(row, col, board, n))
        {
          board[row][col] = 'Q';
          Solve(col + 1, board, res, n);
          board[row][col] = '.';
        }
      }
    }

    bool IsSafe(int row,int col,char[][] board,int n)
    {
      //Check For Upper Diagnoal
      int duprow = row;
      int dupcol = col;

      while(row>=0 && col >= 0)
      {
        if (board[row][col] == 'Q') return false;
        row--;
        col--;
      }

      col = dupcol;
      row = duprow;

      while (col >= 0)
      {
        if (board[row][col] == 'Q') return false;
        col--;
      }

      row = duprow;
      col = dupcol;

      while(row<n && col >= 0)
      {
        if (board[row][col]=='Q') return false;
        row++;
        col--;
      }
      return true;
    }


  }


}
