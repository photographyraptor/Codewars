//Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

fn digitize(n: u64) -> Vec<u8> {
    let mut v: Vec<u8> = Vec::new();
    
    for d in n.to_string().chars().rev() {
        v.push(d.to_digit(10).unwrap() as u8);
    }
    
    return v;
}