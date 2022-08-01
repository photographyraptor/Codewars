/* DESCRIPTION:
Write a function done_or_not/DoneOrNot passing a board (list[list_lines]) as parameter. If the board is valid return 'Finished!', otherwise return 'Try again!'

Sudoku rules:

Complete the Sudoku puzzle so that each and every row, column, and region contains the numbers one through nine only once.

Rows:


There are 9 rows in a traditional Sudoku puzzle. Every row must contain the numbers 1, 2, 3, 4, 5, 6, 7, 8, and 9. There may not be any duplicate numbers in any row. In other words, there can not be any rows that are identical.

In the illustration the numbers 5, 3, 1, and 2 are the "givens". They can not be changed. The remaining numbers in black are the numbers that you fill in to complete the row.

Columns:


There are 9 columns in a traditional Sudoku puzzle. Like the Sudoku rule for rows, every column must also contain the numbers 1, 2, 3, 4, 5, 6, 7, 8, and 9. Again, there may not be any duplicate numbers in any column. Each column will be unique as a result.

In the illustration the numbers 7, 2, and 6 are the "givens". They can not be changed. You fill in the remaining numbers as shown in black to complete the column.

Regions


A region is a 3x3 box like the one shown to the left. There are 9 regions in a traditional Sudoku puzzle.

Like the Sudoku requirements for rows and columns, every region must also contain the numbers 1, 2, 3, 4, 5, 6, 7, 8, and 9. Duplicate numbers are not permitted in any region. Each region will differ from the other regions.

In the illustration the numbers 1, 2, and 8 are the "givens". They can not be changed. Fill in the remaining numbers as shown in black to complete the region. */

using System;
using System.Collections.Generic;

public class Sudoku
{
  public static string DoneOrNot(int[][] board)
  {
    if (!DoneHorizontal(board)) return "Try again!";
    if (!DoneVertical(board)) return "Try again!";
    if (!DoneSquare(board)) return "Try again!";
    return "Finished!";
  }
  
  private static bool DoneHorizontal(int[][] board) {
    foreach(var row in board) {
      HashSet<int> hash = new HashSet<int>();
      foreach(var i in row) {
        hash.Add(i);
      }
      if (hash.Count != 9) return false;
    }
    return true;
  }  
  
  private static bool DoneVertical(int[][] board) {
    for(var j=0; j<9; j++) {
      HashSet<int> hash = new HashSet<int>();
      for(var i =0; i<9; i++) {        
        hash.Add(board[i][j]);
      }
      if (hash.Count != 9) return false;
    }
    return true;
  }
  
  
  private static bool DoneSquare(int[][] board) {
    for(var si=0; si<3; si++) {
      HashSet<int> hash = new HashSet<int>();
      for(var sj=0; sj<3; sj++) {
        hash.Add(board[0 + 3*si][0 + 3*sj]);  
        hash.Add(board[0 + 3*si][1 + 3*sj]);  
        hash.Add(board[0 + 3*si][2 + 3*sj]);  
        hash.Add(board[1 + 3*si][0 + 3*sj]);  
        hash.Add(board[1 + 3*si][1 + 3*sj]);  
        hash.Add(board[1 + 3*si][2 + 3*sj]);  
        hash.Add(board[2 + 3*si][0 + 3*sj]);  
        hash.Add(board[2 + 3*si][1 + 3*sj]);  
        hash.Add(board[2 + 3*si][2 + 3*sj]);
        if (hash.Count != 9) return false;
      }
    }
    return true;
  }
  
}