/* DESCRIPTION:
Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces. */

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
      char[] vowels = {'a','e','i','o','u'};
      int vowelCount = 0;
            
      foreach(var c in str) {
        if (vowels.Contains(c)) {
          vowelCount++;  
        }        
      }
      
      return vowelCount;
    }
}