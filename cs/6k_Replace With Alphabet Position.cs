/* DESCRIPTION:
Welcome.

In this kata you are required to, given a string, replace every letter with its position in the alphabet.

If anything in the text isn't a letter, ignore it and don't return it.

"a" = 1, "b" = 2, etc.

Example
Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" ( as a string ) */

using System.Collections.Generic;
using System;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    var result = "";
    List<string> list = new List<string>
    (new string[]
    {"","A","B","C","D","E","F","G","H","I","J","K","L","M",
    "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"}
    );
    text = text.ToUpper();
    for(int i =0; i< text.Length; i++)
    {
        if (list.Contains(text[i].ToString())) result += list.FindIndex(x => x == text[i].ToString()) + " ";
    }
    result = result.Remove(result.Length -1);
    
    return result;
  }
}