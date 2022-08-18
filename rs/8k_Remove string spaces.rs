//Simple, remove the spaces from the string, then return the resultant string.

fn no_space(x : String) -> String{
    let mut trimmed = String::new();
    
    for c in x.chars() {
        if c != ' ' {
            trimmed.push(c)
        }
    }    
    
    return trimmed;
}