/*
Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.

If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.
*/

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    var chars = new List<char>();
    chars.AddRange(s);
    
    foreach(var c in s) {
      var repCount = chars.Where(w => char.ToLower(w) == char.ToLower(c)).Count();
      if (repCount == 1) {
        return c.ToString();
      }
    }
    return "";
  }
}