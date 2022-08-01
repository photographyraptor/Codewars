/* DESCRIPTION:
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0} */

using System;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    var c = arr.Length;
    var res = new int[c];
    var zeros = 0;
    
    for(int i =0; i<c; i++)
    {
      if (arr[i] > 0) 
      {
        res.SetValue(arr[i], i - zeros);
      }
      else if (arr[i]==0)
      {
        zeros += 1;
        res.SetValue(0,c-zeros);
      }
    }
    
    return res;
  }
}