/*Given a list of integers, determine whether the sum of its elements is odd or even.

Give your answer as a string matching "odd" or "even".

If the input array is empty consider it as: [0] (array with a zero).*/

fn odd_or_even(numbers: Vec<i32>) -> String {
    if numbers.iter().sum::<i32>() % 2 == 0 {
        return "even".to_string();
    }
    return "odd".to_string();
}