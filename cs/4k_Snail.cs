/* DESCRIPTION:
Snail Sort
Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

array = [[1,2,3],
         [4,5,6],
         [7,8,9]]
snail(array) #=> [1,2,3,6,9,8,7,4,5]
For better understanding, please follow the numbers of the next array consecutively:

array = [[1,2,3],
         [8,9,4],
         [7,6,5]]
snail(array) #=> [1,2,3,4,5,6,7,8,9]
This image will illustrate things more clearly:


NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.

NOTE 2: The 0x0 (empty matrix) is represented as en empty array inside an array [[]]. */


using System.Collections.Generic;

public class SnailSolution
{
   public static int[] Snail(int[][] array)
   {
    var snailed = new List<int>();
    var n = array.Length;
    
    for(var sq = 0; sq<n; sq++) {
      if (n*2 -1 > sq*4) snailed.AddRange(getUp(array, sq, n));
      if (n*2 -1 > sq*4 +1) snailed.AddRange(getRight(array, sq, n));
      if (n*2 -1 > sq*4 +2) snailed.AddRange(getDown(array, sq, n));
      if (n*2 -1 > sq*4 +3) snailed.AddRange(getLeft(array, sq, n));
    }

    return snailed.ToArray();
   }
  
   private static List<int> getUp(int[][] array, int sq, int n) {
     var candidates = new List<int>(array[sq]);
     
     var i = 0;
     while (sq > i) {
      candidates.RemoveAt(candidates.Count - 1);
      i++;
     }
     
     i =0;
     while (sq > i) {
      candidates.RemoveAt(0);
      i++;
     }
  
     return candidates;
   }
     
   private static List<int> getRight(int[][] array, int sq, int n) {
     var candidates = pickRight(array, sq, n);
     candidates.RemoveAt(0);
     
     var i = 0;
     while (sq > i) {
      candidates.RemoveAt(candidates.Count - 1);
      i++;
     }
     
     i = 0;
     while (sq > i) {
      candidates.RemoveAt(0);
      i++;
     }
     
     return candidates;
   }
  
  private static List<int> getDown(int[][] array, int sq, int n) {
     var candidates = new List<int>(array[n - (1 + sq)]);
     candidates.Reverse();
     candidates.RemoveAt(0);
     
     var i = 0;
     while (sq > i) {
      candidates.RemoveAt(candidates.Count -1);
      i++;
     }
     
     i =0;
     while (sq > i) {
      candidates.RemoveAt(0);
      i++;
     }
    
     return candidates;
   }
  
   private static List<int> getLeft(int[][] array, int sq, int n) {
     var candidates = pickLeft(array, sq, n);
     candidates.RemoveAt(candidates.Count -1);
     candidates.RemoveAt(0);

     var i = 0;
     while (sq > i) {
      candidates.RemoveAt(candidates.Count - 1);
      i++;
     }
     
     i = 0;
     while (sq > i) {
      candidates.RemoveAt(0);
      i++;
     }
     
     return candidates;
   }
  
  private static List<int> pickRight(int[][] array, int sq, int n) {
    var candidates = new List<int>();
    for(var i=0; i<n; i++) {
      var x = array[i];
      candidates.Add(x[n - (1 + sq)]);
    }
    return candidates;
  }
  
  private static List<int> pickLeft(int[][] array, int sq, int n) {
    var candidates = new List<int>();
    for(var i=0; i<n; i++) {
      var x = array[i];
      candidates.Add(x[0 + sq]);
    }
    candidates.Reverse();
    return candidates;
  }
  
}