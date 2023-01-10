/*
Given a string of words, you need to find the highest scoring word.

Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

For example, the score of abad is 8 (1 + 2 + 1 + 4).

You need to return the highest scoring word as a string.

If two words score the same, return the word that appears earliest in the original string.

All letters will be lowercase and all inputs will be valid.
*/

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string High(string s)
  {
    var result = "";
    var dic = new Dictionary<char, int>();
    dic.Add('a', 1);dic.Add('b', 2);dic.Add('c', 3);
    dic.Add('d', 4);dic.Add('e', 5);dic.Add('f', 6);
    dic.Add('g', 7);dic.Add('h', 8);dic.Add('i', 9);
    dic.Add('j', 10);dic.Add('k', 11);dic.Add('l', 12);
    dic.Add('m', 13);dic.Add('n', 14);dic.Add('o', 15);
    dic.Add('p', 16);dic.Add('q', 17);dic.Add('r', 18);
    dic.Add('s', 19);dic.Add('t', 20);dic.Add('u', 21);
    dic.Add('v', 22);dic.Add('w', 23);dic.Add('x', 24);
    dic.Add('y', 25);dic.Add('z', 26);
    
    var prevVal = 0;
    foreach(var w in s.Split(" ")) {
      var val = 0;
      foreach(var c in w) {
        val += dic.FirstOrDefault(x => x.Key == Char.ToLower(c)).Value;
      }
      if (prevVal < val) {
        result = w;
        prevVal = val;
      }
    }
    
    return result;
  }
}