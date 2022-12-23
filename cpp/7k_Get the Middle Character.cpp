/*
You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.
*/

std::string get_middle(std::string input) 
{
  int l = input.length();
  std::string s;
  
  if(l % 2 == 0) {
    s.append(1, input[(l/2) -1]);
    s.append(1, input[l/2]);
  }
  else {    
    s.append(1, input[l/2]);
  }
  
  return s;
}