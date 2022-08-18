//Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.

fn bool_to_word(value: bool) -> &'static str {
    if value {
        return "Yes";
    }
    return "No";
}