/* DESCRIPTION:
The number 89 is the first integer with more than one digit that fulfills the property partially introduced in the title of this kata. What's the use of saying "Eureka"? Because this sum gives the same number.

In effect: 89 = 8^1 + 9^2

The next number in having this property is 135.

See this property again: 135 = 1^1 + 3^2 + 5^3

We need a function to collect these numbers, that may receive two integers a, b that defines the range [a, b] (inclusive) and outputs a list of the sorted numbers in the range that fulfills the property described above.

Let's see some cases:

sum_dig_pow(1, 10) == [1, 2, 3, 4, 5, 6, 7, 8, 9]

sum_dig_pow(1, 100) == [1, 2, 3, 4, 5, 6, 7, 8, 9, 89]
If there are no numbers of this kind in the range [a, b] the function should output an empty list.

sum_dig_pow(90, 100) == [] */

using System;
using System.Linq;
using System.Collections.Generic;

public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b) 
    {
      var l = new List<long>();
      var il = new List<long>();
      
      for(var j=a; j<b; j++)
      {
        double calc = 0;
        il = intToListInt(j);
        
        for(var k=0; k<il.Count(); k++)
        {
          calc += Math.Pow(il[k],k+1);
        }
        
        if (j == calc)
        {
          l.Add(j);
        }
      }
      return listToArray(l);
   }


  private static List<long> intToListInt (long a)
  {
    var l = new List<long>();
    while(a > 0)
    {
      l.Add(a % 10);
      a = a / 10;
    }
    l.Reverse();
    return l;   
  }

  private static long[] listToArray (List<long> l)
  {   
    var res = new long[l.Count()];
  
    for(var i=0; i< l.Count(); i++)
    {
      res.SetValue(l[i],i);
    }
  
    return res;
  }
  
}