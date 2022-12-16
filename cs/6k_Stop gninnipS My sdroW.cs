/*
Write a function that takes in a string of one or more words, 
and returns the same string, but with all five or more letter words reversed
(Just like the name of this Kata). Strings passed in will consist of only letters and spaces.
Spaces will be included only when more than one word is present.
*/

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    var rev = string.Empty;
    
    foreach(var word in sentence.Split(" ")) {
      if (word.Length >= 5) {
        var letters = word.ToCharArray();
        Array.Reverse(letters);
        rev += new string(letters);
      }
      else{
        rev += word;
      }
      rev += " ";
    }
    
    return rev.Length > 0 ? rev.Remove(rev.Length - 1) : rev;
  }
}