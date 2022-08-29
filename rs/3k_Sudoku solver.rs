/*
Write a function that will solve a 9x9 Sudoku puzzle. The function will take one argument consisting of the 2D puzzle array, with the value 0 representing an unknown square.

The Sudokus tested against your function will be "easy" (i.e. determinable; there will be no need to assume and test possibilities on unknowns) and can be solved with a brute-force approach.
*/

fn sudoku(puzzle: &mut [[u8; 9]; 9]) {
    sudoku_rec(puzzle);
}

fn sudoku_rec(puzzle: &mut [[u8; 9]; 9]) -> bool {
    let mut pos: Vec<u8>;
    let mut pos_h: Vec<u8>;
    let mut pos_v: Vec<u8>;
    let mut pos_s: Vec<u8>;
    
    for i in 0..9 {
        for j in 0..9 {
            if puzzle[i as usize][j as usize] == 0 {
                println!("FINDING: {},{}: ", i, j);
                pos = Vec::new();
                pos_h = hor(*puzzle, [i, j]);
                pos_v = ver(*puzzle, [i, j]);
                pos_s = sqr(*puzzle, [i, j]);
                
                for o in pos_h {
                    if pos_v.contains(&o) && pos_s.contains(&o) {
                        pos.push(o);
                        println!("   p: {}", o);
                    }
                }
                
                if pos.is_empty() {
                    println!("EMPTY: {},{}   ", i, j);
                    return false;
                }
                
                for p in pos {
                    puzzle[i as usize][j as usize] = p;
                    println!("TRY: {},{}->{}", i, j, p);
                    if sudoku_rec(puzzle) {                        
                        println!("TRUE");
                        return true;
                    }
                    println!("FAIL: {},{}->{}", i, j, p);
                }
            }
        }
    }
    return true;
}


fn hor(puzzle: [[u8; 9]; 9], pos: [u8; 2]) -> Vec<u8> {
    let mut v = Vec::new();    
    let line = puzzle[pos[0] as usize];
    
    for i in 0..9 {
        if !line.contains(&i) {
            v.push(i);
        }
    }
    
    return v;
}


fn ver(puzzle: [[u8; 9]; 9], pos: [u8; 2]) -> Vec<u8> {
    let mut v = Vec::new();    
    let mut line = Vec::new();
    
    for i in 0..9 {
        line.push(puzzle[i as usize][pos[1] as usize]);
    }
    
    for i in 1..9 {   
        if !line.contains(&i) {
            v.push(i);
        }
    }
    
    return v;
}


fn sqr(puzzle: [[u8; 9]; 9], pos: [u8; 2]) -> Vec<u8> {
    let mut v = Vec::new();
    let mut val;
    let mut sqr: Vec<u8> = Vec::new();
    let mut hp: Vec<usize> = Vec::new();
    let mut vp: Vec<usize> = Vec::new();
    
    if pos[0] <= 2 {
        hp = [0, 1, 2].to_vec();
    }
    else if pos[0] >= 3 && pos[0] <= 5 {
        hp = [3, 4, 5].to_vec();
    }
    else if pos[0] >= 6 && pos[0] <= 8 {
        hp = [6, 7, 8].to_vec();
    }
    
    if pos[1] <= 2 {
        vp = [0, 1, 2].to_vec();
    }
    else if pos[1] >= 3 && pos[1] <= 5 {
        vp = [3, 4, 5].to_vec();
    }
    else if pos[1] >= 6 && pos[1] <= 8 {
        vp = [6, 7, 8].to_vec();
    }
    
    for i in hp {
        for j in &vp {
            val = puzzle[i as usize][*j as usize];
            if val > 0 {
                sqr.push(val);   
            }
        }
    }
    
    for i in 1..9 {
        if !sqr.contains(&i) {
            v.push(i);
        }
    }
    
    return v;
}