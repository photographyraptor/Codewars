//Simple, given a string of words, return the length of the shortest word(s).

//String will never be empty and you do not need to account for different data types

fn find_short(s: &str) -> u32 {
    let words = s.split(" ").collect::<Vec<&str>>();
    let mut shortest = words[0].chars().count();
    
    for word in words {
        if shortest >= word.chars().count() {
            shortest = word.chars().count();
        }
    }
    
    return shortest as u32;
}