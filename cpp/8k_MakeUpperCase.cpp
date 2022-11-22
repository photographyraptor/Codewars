/*
Write a function which converts the input string to uppercase.
*/

#include <string>

std::string makeUpperCase (const std::string& input_str)
{
  std::string s = "";
  
  for(int i = 0; i < input_str.size(); i++) {
      s.append(1, std::toupper(input_str.at(i)));
  }
  
  return s;
}