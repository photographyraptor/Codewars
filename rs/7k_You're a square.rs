/*
Given an integral number, determine if it's a square number:
*/

fn is_square(n: i64) -> bool {
    let f = (n as f64).sqrt();
        
    if f.is_nan() || f % 1.0 != 0.0 {
        return false;
    }
    
    return true;
}