/*
ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
*/

using System;
using System.Linq;
using System.Collections.Generic; 

public class Kata
{
  public static string Rot13(string message)
  {
    var dic = new Dictionary<char, int>();
    dic.Add('a', 0);dic.Add('b', 1);dic.Add('c', 2);
    dic.Add('d', 3);dic.Add('e', 4);dic.Add('f', 5);
    dic.Add('g', 6);dic.Add('h', 7);dic.Add('i', 8);
    dic.Add('j', 9);dic.Add('k', 10);dic.Add('l', 11);
    dic.Add('m', 12);dic.Add('n', 13);dic.Add('o', 14);
    dic.Add('p', 15);dic.Add('q', 16);dic.Add('r', 17);
    dic.Add('s', 18);dic.Add('t', 19);dic.Add('u', 20);
    dic.Add('v', 21);dic.Add('w', 22);dic.Add('x', 23);
    dic.Add('y', 24);dic.Add('z', 25);
    
    var result = "";
    
    foreach(var c in message) {
      if (!Char.IsLetter(c)) {
        result += c;
        continue;
      }
      
      var pos = dic.FirstOrDefault(x => x.Key == Char.ToLower(c)).Value + 13;
      
      if (pos > 25) {
        pos = pos - 26;
      }
      
      var val = dic.FirstOrDefault(x => x.Value == pos).Key;
      if (Char.ToLower(c) != c) {
        val = Char.ToUpper(val);
      }
      
      result += val.ToString();        
    }
    
    return result;
  }
}