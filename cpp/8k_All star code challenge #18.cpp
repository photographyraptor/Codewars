/*
Create a function that accepts 2 string arguments and returns an integer of the count of occurrences the 2nd argument is found in the first one.

If no occurrences can be found, a count of 0 should be returned.
*/

#include <string>

unsigned int strCount(std::string word, char letter){
  unsigned int count = 0;
  
  for (char c : word) {
    if (c == letter) {
      count += 1;
    }  
  }
  
  return count;  
}