//He wants you to write a simple program telling him if he will be able to fit all the passengers

//If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.

fn enough(cap: i32, on: i32, wait: i32) -> i32 {
    let total = on + wait;
    if cap >= total {
        return 0;
    }
    return total - cap;
}