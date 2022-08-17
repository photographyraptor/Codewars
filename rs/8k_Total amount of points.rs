//Our football team finished the championship. The result of each match look like "x:y". Results of all matches are recorded in the collection.

//For example: ["3:1", "2:2", "0:1", ...]

//Write a function that takes such collection and counts the points of our team in the championship. Rules for counting points for each match:

//if x > y: 3 points
//if x < y: 0 point
//if x = y: 1 point

fn points(games: &[String]) -> u32 {
    let mut points = 0;
    let mut vgames = Vec::from(games);

    for vgame in vgames
    {
        let p1 = vgame.chars().nth(0).unwrap();
        let p2 = vgame.chars().nth(2).unwrap();
        if p1 > p2 {
            points = points + 3;
        }
        else if p1 == p2 {
            points = points + 1;
        }
    }
    
    return points;
}