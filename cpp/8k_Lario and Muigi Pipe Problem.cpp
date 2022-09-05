/*
Given the a list of numbers, return a fixed list so that the values increment by 1 for each index from the minimum value up to the maximum value (both included).
*/

#include <vector>

std::vector<int> pipe_fix(const std::vector<int>& nums) {
  int max =  *max_element(nums.begin(), nums.end());
  int min =  *min_element(nums.begin(), nums.end());
  std::vector<int> vec;
  
  for (int i = min; i <= max; i++) {
    vec.push_back(i);
  }
  
  return vec;
}