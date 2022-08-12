//Write a function which calculates the average of the numbers in a given list.
//Note: Empty arrays should return 0.

fn find_average(slice: &[f64]) -> f64 {
    let mut avg: f64 = 0.0;
    
    if slice.len() == 0
    {
        return 0.0;
    }
    
    for entry in slice {
        avg += *entry
    }
    
    avg = avg / (slice.len() as f64);
    
    return avg;
}