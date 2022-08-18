//Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.

fn summation(n: i32) -> i32 {
    return (1..n+1).sum();
}