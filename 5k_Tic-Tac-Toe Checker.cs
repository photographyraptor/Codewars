/* DESCRIPTION:
If we were to set up a Tic-Tac-Toe game, we would want to know whether the board's current state is solved, wouldn't we? Our goal is to create a function that will check that for us!

Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is an "X", or 2 if it is an "O", like so:

[[0, 0, 1],
 [0, 1, 2],
 [2, 1, 0]]
We want our function to return:

-1 if the board is not yet finished AND no one has won yet (there are empty spots),
1 if "X" won,
2 if "O" won,
0 if it's a cat's game (i.e. a draw).
You may assume that the board passed in is valid in the context of a game of Tic-Tac-Toe. */

using System;
using System.Collections.Generic;

public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
    var playsToWin = new List<List<List<int>>>
    {
      new List<List<int>>
      {
        new List<int>{0,0},
        new List<int>{1,0},
        new List<int>{2,0}
      },
      new List<List<int>>
      {
        new List<int>{0,1},
        new List<int>{1,1},
        new List<int>{2,1}
      },
      new List<List<int>>
      {
        new List<int>{0,2},
        new List<int>{1,2},
        new List<int>{2,2}
      },
      new List<List<int>>
      {
        new List<int>{0,0},
        new List<int>{0,1},
        new List<int>{0,2}
      },
      new List<List<int>>
      {
        new List<int>{1,0},
        new List<int>{1,1},
        new List<int>{2,2}
      },
      new List<List<int>>
      {
        new List<int>{2,0},
        new List<int>{2,1},
        new List<int>{2,2}
      },
      new List<List<int>>
      {
        new List<int>{0,0},
        new List<int>{1,1},
        new List<int>{2,2}
      },
      new List<List<int>>
      {
        new List<int>{2,0},
        new List<int>{1,1},
        new List<int>{0,2}
      }
    };
    
    for (var p = 1; p<3; p++)
    {
      foreach(var play in playsToWin)
      {
        var hasWon = 0;
        foreach(var spot in play)
        {
          if (p != board[spot[0],spot[1]]) break;
          else hasWon++;
        }
        if (hasWon == 3) return p;
      }
    }
    if (hasEmptyCell(board)) return -1;
    else return 0;
  }
  
  private bool hasEmptyCell(int[,] board)
  {
    for(var i=0; i<3; i++)
    {
      for(var j=0; j<3; j++)
      {
        if (board[i,j] == 0) return true;
      }
    }
    
    return false;
  }
}