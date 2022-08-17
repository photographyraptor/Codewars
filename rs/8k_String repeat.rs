//Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.

fn repeat_str(src: &str, count: usize) -> String {
    let mut st = String::new();
    
    for _i in 0..count
    {
        st.push_str(src);    
    }
    
    return st;
}