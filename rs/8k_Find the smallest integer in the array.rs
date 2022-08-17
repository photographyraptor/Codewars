//Given an array of integers your solution should find the smallest integer.
//For example:
//Given [34, 15, 88, 2] your solution will return 2
//Given [34, -345, -1, 100] your solution will return -345
//You can assume, for the purpose of this kata, that the supplied array will not be empty.

fn find_smallest_int(arr: &[i32]) -> i32 {
    let i = arr.iter().min();
    let mut t = 0;
    match i {
        Some(min) => t = *min,
        None      => t = 0,
    }
    
    return t;
}