//Given a year, return the century it is in.

fn century(year: u32) -> u32 {
    return ((year -1) / 100) + 1;    
}