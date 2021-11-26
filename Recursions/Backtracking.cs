using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    public static class Backtracking
    {
        public static bool isSafe(int[,] board ,int n,int i ,int j)
        {
            //check in the row 
            for(int row = 0; row < i; ++row)
             if(board[row , j] == 1)
                    return false;

            //check in the col
            for (int col = 0; col < j; ++col)
                if (board[i, col] == 1)
                    return false;

            //check in upper left diagonal
            for(int x = i , y = j ;x>=0 && y >= 0; x-- , y--)
             if(board[x ,y] == 1)
                    return false;

            //check in upper right diagonal 
            for(int x = i , y = j; x>=0 && y<=n-1; x-- , y++)
             if(board[x,y] == 1)
                    return false;

            return true;
        }
        public static void printTheBoard(int[,] board , int n)
        {
            for(int i = 0; i< n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    if (board[i, j] == 1) Console.Write("Q ");
                    else Console.Write("_ ");
                }
                Console.WriteLine();
            }
        }
        public static bool SolveNQueenUtil(int[,] board, int i, int n)
        {
            if (i >= n)
            {
                printTheBoard(board, n);
                return true;
            }
            for(int col = 0; col < n; ++col)
            {
                if(isSafe(board , n , i, col))
                {
                    board[i, col] = 1;
                    if (SolveNQueenUtil(board, i + 1, n))
                    {
                        return true;
                    }
                    board[i, col] = 0;         //backtracking
                }
            }
            return false;
        }
        public static void SolveNQueen(int n )
        { 

            int[,] board = new int[n, n];
            if(SolveNQueenUtil(board , 0 , n) == false)
            {
                Console.WriteLine("Not possible");
            }
            return;

        }
        public static void nQueenProblem(int n)
        {
            SolveNQueen(n);
        }
    }
}
