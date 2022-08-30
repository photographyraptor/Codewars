/*
Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.
*/

fn make_readable(seconds: u32) -> String {
    let mut s = String::new();
    let hor = seconds / 3600;
    let min = (seconds % 3600) / 60;
    let sec = seconds % 60;
    
    s.push_str(&timeToStr(hor));
    s.push(':');
    s.push_str(&timeToStr(min));
    s.push(':');
    s.push_str(&timeToStr(sec));
    
    return s;
}

fn timeToStr(value: u32) -> String {
    let mut s = String::new();
    
    if value < 10 {
        s.push('0');
    }
    
    s.push_str(&value.to_string());
    
    return s;
}