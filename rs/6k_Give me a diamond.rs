/*
You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters. Trailing spaces should be removed, and every line must be terminated with a newline character (\n).

Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.
*/

fn print(n: i32) -> Option<String> {
    let mut s = String::new();

    if n < 1 || n % 2 == 0 {
        return None;
    }
    
    for i in (1..n+1).step_by(2) {
        for j in 0..((n-i)/2) {
            s.push(' ');
        }
        for j in 0..i {
            s.push('*');   
        }
        s.push_str("\n");
    }
    
    for i in (1..n-1).rev().step_by(2) {
        for j in 0..((n-i)/2) {
            s.push(' ');
        }
        for j in 0..i {
            s.push('*');   
        }
        s.push_str("\n");
    }
        
    return Some(s);
}