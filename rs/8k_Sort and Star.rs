//You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.
//The returned value must be a string, and have "***" between each of its letters.
//You should not remove or add elements from/to the array.

fn two_sort(arr: &[&str]) -> String {
    let mut sorted = Vec::from(arr);
    sorted.sort();
    let mut first = String::new();
    
    for c in sorted[0].chars()
    {
        first.push(c);
        first.push_str("***");
    }
    
    first.pop();
    first.pop();
    first.pop();
    
    return first;
}

