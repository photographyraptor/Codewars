/*
Implement a function which convert the given boolean value into its string representation.

Note: Only valid inputs will be given.
*/

#include <string>

std::string boolean_to_string(bool b){
  if (b) return "true";
  return "false";
}