//Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char

fn xo(s: &'static str) -> bool {
    let x = s.chars().filter(|n| *n == 'x' || *n == 'X').count();
    let o = s.chars().filter(|n| *n == 'o' || *n == 'O').count();
    return x == o;
}