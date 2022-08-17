//It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the original string. You don't have to worry with strings with less than two characters.

pub fn remove_char(s: &str) -> String {
    let mut st = String::from(s);
    st.remove(0);
    st.pop();
    return st;
}