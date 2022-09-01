/*
Write a function that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.
*/

fn valid_parentheses(s: &str) -> bool {
    let mut i: i32 = 0;
    
    for c in s.chars() {
        if c == '(' {
            i += 1;
        } else if c == ')' {
            i -= 1;
        }
        
        if i < 0 {
            return false;
        }
    }
    
    return i == 0;
}