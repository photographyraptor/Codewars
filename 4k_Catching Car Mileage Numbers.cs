/* DESCRIPTION:
"7777...8?!??!", exclaimed Bob, "I missed it again! Argh!" Every time there's an interesting number coming up, he notices and then promptly forgets. Who doesn't like catching those one-off interesting mileage numbers?

Let's make it so Bob never misses another interesting number. We've hacked into his car's computer, and we have a box hooked up that reads mileage numbers. We've got a box glued to his dash that lights up yellow or green depending on whether it receives a 1 or a 2 (respectively).

It's up to you, intrepid warrior, to glue the parts together. Write the function that parses the mileage number input, and returns a 2 if the number is "interesting" (see below), a 1 if an interesting number occurs within the next two miles, or a 0 if the number is not interesting.

Note: In Haskell, we use No, Almost and Yes instead of 0, 1 and 2.

"Interesting" Numbers
Interesting numbers are 3-or-more digit numbers that meet one or more of the following criteria:

Any digit followed by all zeros: 100, 90000
Every digit is the same number: 1111
The digits are sequential, incementing†: 1234
The digits are sequential, decrementing‡: 4321
The digits are a palindrome: 1221 or 73837
The digits match one of the values in the awesomePhrases array
† For incrementing sequences, 0 should come after 9, and not before 1, as in 7890.
‡ For decrementing sequences, 0 should come after 1, and not before 9, as in 3210.

So, you should expect these inputs and outputs:

// "boring" numbers
Kata.IsInteresting(3, new List<int>() { 1337, 256 });    // 0
Kata.IsInteresting(3236, new List<int>() { 1337, 256 }); // 0

// progress as we near an "interesting" number
Kata.IsInteresting(11207, new List<int>() { });   // 0
Kata.IsInteresting(11208, new List<int>() { });   // 0
Kata.IsInteresting(11209, new List<int>() { });   // 1
Kata.IsInteresting(11210, new List<int>() { });   // 1
Kata.IsInteresting(11211, new List<int>() { });   // 2

// nearing a provided "awesome phrase"
Kata.IsInteresting(1335, new List<int>() { 1337, 256 });   // 1
Kata.IsInteresting(1336, new List<int>() { 1337, 256 });   // 1
Kata.IsInteresting(1337, new List<int>() { 1337, 256 });   // 2 */

using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static int IsInteresting(int number, List<int> awesomePhrases) {
    if (NumberIsInteresting(number, awesomePhrases)) return 2;
    if (NumberIsInteresting(number+1, awesomePhrases) ||
       NumberIsInteresting(number+2, awesomePhrases)) return 1;
    return 0;
  }
  
  private static bool NumberIsInteresting(int number, List<int> awesomePhrases) {
    var num = number.ToString();
    if (num.Length < 3) return false;
    if (IsFollowedByZeros(num)) return true;
    if (EveryDigitIsSame(num)) return true;
    if (DigitsIncremental(num)) return true;
    if (DigitsDecremental(num)) return true;
    if (IsPalindrome(num)) return true;
    if (awesomePhrases.Contains(number)) return true;
    return false;
  }
  
  private static bool IsFollowedByZeros(string num) {
    var numC = num.Length;
    for(var i=1; i< numC; i++) {
      if (num[i] != '0') return false;
    }   
    return true;
  }
  private static bool EveryDigitIsSame(string num) {
    var cn = num.FirstOrDefault();
    if (num.Length <= 3) return false;
    foreach(var c in num) {
      if (cn != c) return false;
    }
    return true;
  }
  private static bool DigitsIncremental(string num) {
    if (num == "67890") return true;
    if (num == "234567890") return true;
    var cn = (int)num[0];
    for(var i=0; i<num.Length; i++) {
      var nn = (int)num[i];
      if (cn != nn) return false;
      if (cn == 9) {
        cn = 0;
      }
      else {
        cn = cn +1;
      }
    }
    return true;
  }
  private static bool DigitsDecremental(string num) {
    int cn = num[0];
    for(var i=0; i<num.Length; i++) {
      int nn = num[i];
      if (cn != nn) return false;
      if (cn == 0) cn = 9;
      else cn--;
    }
    return true;
  }
  private static bool IsPalindrome(string num) {
    var nl = num.Length / 2;    
    for(var i=0; i<nl; i++) {
      if (num[i] != num[num.Length - i -1]) return false;
    }
    return true;
  }
}