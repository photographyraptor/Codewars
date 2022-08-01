/* DESCRIPTION:
Complete the solution so that it reverses the string passed into it.

'world'  =>  'dlrow'
'word'   =>  'drow' */

using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char[] chars = str.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
  }
}