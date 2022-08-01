/* DESCRIPTION:
Complete the square sum function so that it squares each number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9. */

using System;

public static class Kata
{
  public static int SquareSum(int[] n)
  { 
    double res = 0;
    foreach(var n1 in n) {
      res = res + Math.Pow(n1, 2);
    }
    return (int)res;
  }
}