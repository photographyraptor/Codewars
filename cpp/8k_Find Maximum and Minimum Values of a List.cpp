/*
Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively.
*/

#include <vector>
using namespace std;

int min(vector<int> list){
    
    return *min_element(list.begin(), list.end());
}

int max(vector<int> list){
    
    return *max_element(list.begin(), list.end());
}