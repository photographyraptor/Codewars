//Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.

fn remove_every_other(arr: &[u8]) -> Vec<u8> {
    let mut v = Vec::new();
    let mut b = true;
    
    for a in arr {
        if b {
            v.push(*a);
            b = false;
        }    
        else
        {
            b = true;
        }
    }    
    
    return v;
}