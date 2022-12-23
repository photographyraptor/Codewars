/*
Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n ( inclusive ).
*/

#include <vector>
#include <cstdint>
#include <cmath>

std::vector<uint64_t> powers_of_two(int n) {
  std::vector<uint64_t> p;
  for(int i=0; i<=n; i++) {
    p.push_back(pow(2, i));
  }
  
  return p;
}