/*
There is an array with some numbers. All numbers are equal except for one. Try to find it!

find_uniq(std::vector<float>{1, 1, 1, 2, 1, 1});  // --> 2
find_uniq(std::vector<float>{0, 0, 0.55, 0, 0});  // --> 0.55
It’s guaranteed that array contains at least 3 numbers.

The tests contain some very huge arrays, so think about performance.
*/

float find_uniq(const std::vector<float> &v)
{
  for(int i=0; i<v.size(); i++) {
    if (v[i] == v[0] && (v[0] == v[1] || v[0] == v[v.size() - 1])) {}
    else {
      return v[i];
    }
  }
}