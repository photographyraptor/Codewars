//Write a function to split a string and convert it into an array of words.

fn string_to_array(s: &str) -> Vec<String> {
    let mut v = Vec::new();
    let mut word = String::new();
    
    for c in s.chars()
    {
        if c == ' '
        {
            v.push(word);
            word = String::new();
        }
        else
        {
            word.push(c);
        }
    }
    
    v.push(word);
    
    return v;
}
