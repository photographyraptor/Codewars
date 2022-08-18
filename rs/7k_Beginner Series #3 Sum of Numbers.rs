//Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.
//Note: a and b are not ordered!

fn get_sum(a: i64, b: i64) -> i64 {  
    
    if a > b {
        return get_sum1(b, a);
    }
            
    return get_sum1(a, b);
}

fn get_sum1(a: i64, b: i64) -> i64 {
    let mut res = 0 as i64;
    
    for i in (a..b) {
        res += i;        
    }
    
    return res + b
}