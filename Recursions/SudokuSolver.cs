using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    public class SudokuSolver
    {
       
        public static void solve()
        {
            int[,] board =new int[,] {
                { 5, 3, 0, 0, 7, 0, 0, 0, 0},
                 { 6, 0, 0, 1, 9, 5, 0, 0, 0},
                 { 0, 9, 8, 0, 0, 0, 0, 6, 0},
                 { 8, 0, 0, 0, 6, 0, 0, 0, 3},
                 { 4, 0, 0, 8, 0, 3, 0, 0, 1},
                 { 7, 0, 0, 0, 2, 0, 0, 0, 6},
                 { 0, 6, 0, 0, 0, 0, 2, 8, 0},
                 { 0, 0, 0, 4, 1, 9, 0, 0, 5},
                 { 0, 0, 0, 0, 8, 0, 0, 7, 9} 
            };
            int n = 9;
            bool success = SolveUtil(board, n, 0, 0);

            if (success is true)
            {
                printTheBoard(board, n);
            }
            else
            {
                Console.WriteLine("Cannot solve");
            }

        }

        private static void printTheBoard(int[,] board, int n)
        {
            for(int i = 0;  i < n; ++i)
            {
                for(int j =  0; j < n; ++j)
                {
                    Console.Write(board[i, j] + " ");
                    if (j == 2 || j == 5 || j == 8) Console.Write("||");
                }
                Console.WriteLine();
            }
        }

        private static bool SolveUtil(int[,] board, int n, int row, int col)
        {
            if (col == n  && row == n - 1){
                return true;
            }

            if(col == n)
            {
                col = 0;
                row++;
            }

            if (board[row, col] != 0) return SolveUtil(board, n, row, col+1);

            for(int curNum = 1; curNum <= n; ++curNum)
            {
                if(isSafe(board , n, row , col , curNum) is true)
                {
                    board[row , col]=curNum;
                    bool success = SolveUtil(board, n, row, col + 1);
                    if (success is true)
                        return true;
                    board[row, col] = 0;
                }
            }

            return false;
        }

        private static bool isSafe(int[,] board, int n, int row, int col, int curNum)
        {
            for(int i =  0; i < n; ++i)
            {
                if(board[i,col] == curNum)return false;
                if (board[row, i] == curNum) return false;
            }

            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for(int i = 0;  i < 3; ++i)
                for(int j = 0;  j < 3; ++j)
                    if (board[i + startRow, j + startCol] == curNum) 
                        return false;

            return true;
        }
    }
}
