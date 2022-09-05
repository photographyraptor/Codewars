/*
In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
Examples:
    high_and_low("1 2 3 4 5")  // return "5 1"
    high_and_low("1 2 -3 4 5") // return "5 -3"
    high_and_low("1 9 3 4 -5") // return "9 -5"
*/

fn high_and_low(numbers: &str) -> String {
    let mut s = String::new();    
    let split = numbers.split(' ');    
    let v: Vec<_> = split.map(|s| s.parse::<i32>().unwrap()).collect();
    
    let maxv = v.iter().max().unwrap();
    let minv = v.iter().min().unwrap();
    
    s.push_str(&maxv.to_string());
    s.push(' ');
    s.push_str(&minv.to_string());
    
    return s;
}