/*
This time no story, no theory. The examples below show you how to write function accum:

Examples:
    accum("abcd") -> "A-Bb-Ccc-Dddd"
    accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    accum("cwAt") -> "C-Ww-Aaa-Tttt"
*/

fn accum(s:&str)->String {
    let mut r = String::new();
    let mut tc: char = ' ';
    
    for i in 0..s.chars().count() {
        tc = s.chars().nth(i).unwrap();
        r.push(tc.to_ascii_uppercase());
        for j in (0..i) {
            r.push(tc.to_ascii_lowercase());
        }
        r.push('-');
    }    
    r.pop();
    
    return r;
}