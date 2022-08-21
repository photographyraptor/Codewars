/*
Create a function with two arguments that will return an array of the first (n) multiples of (x).

Assume both the given number and the number of times to count will be positive numbers greater than 0.
*/

fn count_by(x: u32, n: u32) -> Vec<u32> {
    let mut v: Vec<u32> = Vec::new();
    
    for i in (1..n+1) {
        v.push(x*i);
    }
    
    return v;
}