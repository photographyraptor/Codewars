/* DESCRIPTION:
Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

Examples:
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
longest(a, a) -> "abcdefghijklmnopqrstuvwxyz" */

using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class TwoToOne 
{
  
  public static string Longest (string s1, string s2) 
  {
    char[] resa = (s1 + s2).ToCharArray();    
    var resh = new HashSet<char>(new List<char>(resa));
    var rl = resh.ToList();
    rl.Sort();
    return new string(rl.ToArray());
  }
}