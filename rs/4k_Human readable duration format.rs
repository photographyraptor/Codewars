/*
Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.

The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.
*/

fn format_duration(seconds: u64) -> String {
    if seconds == 0 {
        return "now".to_string();
    }
    
    let y = seconds / 31536000;
    let d = (seconds % 31536000) / 86400;
    let h = ((seconds % 31536000) % 86400) / 3600;
    let m = (((seconds % 31536000) % 86400) % 3600) / 60;
    let s = (((seconds % 31536000) % 86400) % 3600) % 60;
    let mut items;
    let mut duration = String::new();
        
    if y > 0 {
        duration.push_str(&y.to_string());
        if y > 1 {
            duration.push_str(" years")
        }
        else {
            duration.push_str(" year")
        }
        
        items = 0;
        if d > 0 {
            items += 1;
        }
        if h > 0 {
            items += 1;
        }
        if m > 0 {
            items += 1;
        }
        if s > 0 {
            items += 1;
        }
        
        if items > 1 {
            duration.push_str(", ");
        } else if items == 1 {
            duration.push_str(" and ")
        }
    }    
      
    if d > 0 {
        duration.push_str(&d.to_string());
        if d > 1 {
            duration.push_str(" days")
        }
        else {
            duration.push_str(" day")
        }
        
        items = 0;
        if h > 0 {
            items += 1;
        }
        if m > 0 {
            items += 1;
        }
        if s > 0 {
            items += 1;
        }
        
        if items > 1 {
            duration.push_str(", ");
        } else if items == 1 {
            duration.push_str(" and ")
        }
    }
    
    if h > 0 {
        duration.push_str(&h.to_string());
        if h > 1 {
            duration.push_str(" hours")
        }
        else {
            duration.push_str(" hour")
        }
        
        items = 0;
        if m > 0 {
            items += 1;
        }
        if s > 0 {
            items += 1;
        }
        
        if items > 1 {
            duration.push_str(", ");
        } else if items == 1 {
            duration.push_str(" and ")
        }
    }
    
    if m > 0 {
        duration.push_str(&m.to_string());
        if m > 1 {
            duration.push_str(" minutes")
        }
        else {
            duration.push_str(" minute")
        }
        
        items = 0;
        if s > 0 {
            items += 1;
        }
        
        if items == 1 {
            duration.push_str(" and ")
        }
    }
    
    if s > 0 {
        duration.push_str(&s.to_string());
        if s > 1 {
            duration.push_str(" seconds")
        }
        else {
            duration.push_str(" second")
        }        
    }
    
    return duration;
}
