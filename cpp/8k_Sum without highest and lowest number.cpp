/*
Task
Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).

The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

Mind the input validation.
*/

#include<vector>
#include <bits/stdc++.h>
using namespace std;

int sum(vector<int> numbers)
{
  if (numbers.size() <= 1) return 0;
  
  int sum = 0;
  
  for(std::vector<int>::iterator it = numbers.begin(); it != numbers.end(); ++it) {
    sum += *it;
  }
  
  sum = sum
    - *max_element(numbers.begin(), numbers.end())
    - *min_element(numbers.begin(), numbers.end());
  
  return sum;
}