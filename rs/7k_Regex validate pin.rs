/*
ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

If the function is passed a valid PIN string, return true, else return false.
*/

fn validate_pin(pin: &str) -> bool {
    let s = String::from(pin);
    if s.len() != 4 && s.len() != 6 {
        return false;
    }
    
    for c in pin.chars() {
        if !c.is_digit(10) {
            return false;
        }
    }
    
    return true;
}