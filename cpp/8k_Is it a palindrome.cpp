/*
Write a function that checks if a given string (case insensitive) is a palindrome.
*/

#include <string>

using namespace std;

bool isPalindrom (const std::string& str)
{
  int chars = str.size() / 2;
  
  for (int i = 0; i <= chars; i ++) {
 
    if (std::tolower(str[i]) != std::tolower(str[str.size() -1 - i])) {      
      return false;
    }
  }
  
  return true;
}