/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
*/

fn move_zeros(arr: &[u8]) -> Vec<u8> {
    let mut v:Vec<u8> = Vec::new();
    let mut zeroCount = 0;
    
    for a in arr {
        if *a == 0 {
            zeroCount += 1;
        }
        else {
            v.push(*a);
        }
    }
    
    for i in 0..zeroCount {
        v.push(0);
    }
    
    return v;
}
