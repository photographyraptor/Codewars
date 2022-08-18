//Write a function that returns both the minimum and maximum number of the given list/array.

fn min_max(lst: &[i32]) -> (i32, i32) {
    return (matchVal(lst.iter().min()), matchVal(lst.iter().max()));
}

fn matchVal(val: Option<&i32>) -> i32 {
    match val {
        Some(min) => *min,
        None      => 0,
    }
}