/*
Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple / list (depending on your language) like so: (index1, index2).

For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).

Based on: http://oj.leetcode.com/problems/two-sum/

two_sum(&[1, 2, 3], 4) // return (0, 2) or (2, 0)
*/

fn two_sum(numbers: &[i32], target: i32) -> (usize, usize) {
    let nfs = Vec::from(numbers);
    let c = nfs.len();
    
    for i in 0..c {
        if i < c {
            for j in (i+1)..c {
                if nfs[i] + nfs[j] == target {
                    return (i, j);
                }
            }
        }
    }
    
    return (0, 0);
}
