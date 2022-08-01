/* DESCRIPTION:
If you can't sleep, just count sheep!!

Task:
Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no negative integers.
 */

#include <string>
#include <iostream>

std::string countSheep(int number) {
  
  std::string sheeps = "";
  
  for(int i=1; i<= number; i++) {
    std::string str = std::to_string(i);
    sheeps = sheeps + str + " sheep...";
  }
  
  return sheeps;
}