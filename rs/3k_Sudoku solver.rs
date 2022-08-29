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
    let pos_v: Vec<u8>;
    let pos_s: Vec<u8>;
    
    for i in 0..9 {
        pos_h = hor(*puzzle, i);
        for j in 0..9 {            
            if puzzle[i as usize][j as usize] == 0 {
                pos = Vec::new();
                pos_v = ver(*puzzle, j);
                pos_s = sqr(*puzzle, [i, j]);
                
                for o in &pos_h {
                    if pos_v.contains(&o) && pos_s.contains(&o) {
                        pos.push(*o);
                    }
                }
                
                if pos.is_empty() {
                    puzzle[i as usize][j as usize] = 0;
                    return false;
                }
                
                for p in pos {
                    puzzle[i as usize][j as usize] = p;
                    if sudoku_rec(puzzle) {
                        return true;
                    }
                    puzzle[i as usize][j as usize] = 0;
                }
                return false;
            }
        }
    }
    return true;
}

fn hor(puzzle: [[u8; 9]; 9], pos: u8) -> Vec<u8> {
    let mut v = Vec::new();    
    let line = puzzle[pos as usize];
    
    for i in 1..10 {
        if !line.contains(&i) {
            v.push(i);
        }
    }
    
    return v;
}

fn ver(puzzle: [[u8; 9]; 9], pos: u8) -> Vec<u8> {
    let mut v: Vec<u8> = vec![1,2,3,4,5,6,7,8,9];     
    
    for i in 0..9 {
        v.retain(|&x|x != puzzle[i as usize][pos as usize]);
    }
    
    return v;
}

fn sqr(puzzle: [[u8; 9]; 9], pos: [u8; 2]) -> Vec<u8> {
    let mut v: Vec<u8> = vec![1,2,3,4,5,6,7,8,9];    
    let hp: [usize;3];
    let vp: [usize;3];
    
    if pos[0] <= 2 {
        hp = [0, 1, 2];
    }
    else if pos[0] <= 5 {
        hp = [3, 4, 5];
    }
    else {
        hp = [6, 7, 8];
    }
    
    if pos[1] <= 2 {
        vp = [0, 1, 2];
    }
    else if pos[1] <= 5 {
        vp = [3, 4, 5];
    }
    else {
        vp = [6, 7, 8];
    }
    
    for i in hp {
        for j in &vp {
            v.retain(|&x|x != puzzle[i][*j]);
        }
    }
    
    return v;
}