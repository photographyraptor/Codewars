//Complete the solution so that the function will break up camel casing, using a space between words.

fn solution(s: &str) -> String {
    let mut r = String::new();
    
    for c in s.chars() {
        if c.to_string() == c.to_uppercase().to_string() {
            r.push(' ');
            r.push(c);
        }
        else {
            r.push(c);
        }        
    }
    
    return r;
}