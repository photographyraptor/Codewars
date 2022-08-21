/*
Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)
             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
*/

fn row_sum_odd_numbers(n:i64) -> i64 {
    let mut s = (((n*(n+1)/2) - n)* 2) -1;
    let mut v = Vec::new();
    
    for r in 0..n {
        s += 2;
        v.push(s);
    }
    
    return v.iter().sum();
}