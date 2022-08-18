//Complete the solution so that it reverses the string passed into it.

fn solution(phrase: &str) -> String {
    return phrase.chars().rev().collect::<String>();
}