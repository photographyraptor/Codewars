/*
Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

Examples
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
*/

using System;

public class Kata
{
  public static string PigIt(string str)
  {
    var words = str.Split(" ");
    var rstr = "";
    
    foreach(var word in words) {
      var firstChar = word[0];
      if (!Char.IsLetter(firstChar)) {
        rstr = rstr + firstChar;
      }
      else {
        var newWord = word.Remove(0, 1) + firstChar + "ay";
        rstr = rstr + newWord + " ";
      }
    }
    
    if (rstr[rstr.Length - 1] == ' ') {
      rstr = rstr.Remove(rstr.Length -1, 1);
    }
    
    return rstr;
  }
}