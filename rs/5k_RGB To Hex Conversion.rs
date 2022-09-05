/*
The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
*/

fn rgb(r: i32, g: i32, b: i32) -> String {
    let mut s = String::new();    
    let rr = conv(r);
    let gg = conv(g);
    let bb = conv(b);
        
    if rr.len() == 1 {        
        s.push('0');
    }    
    s.push_str(&rr);    
    
    if gg.len() == 1 {        
        s.push('0');
    }    
    s.push_str(&gg);
    
    if bb.len() == 1 {        
        s.push('0');
    }    
    s.push_str(&bb);
            
    return s
}


fn conv(i: i32) -> String {    
    if i < 0 {
        return "00".to_string();
    }
    else if i > 255 {
        return "FF".to_string();
    }
    else {
        return format!("{:X}", i);
    }
}