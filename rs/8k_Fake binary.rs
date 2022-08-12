// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

// Note: input will never be an empty string

fn fake_bin(s: &str) -> String {
    let mut result: String = "".to_string();
    
    for c in s.chars() {
        if (c as u32 - '0' as u32) < 5 {
            result.push('0');
        }
        else {
            result.push('1');
        }
    }
    
    return result;
}