/*
Sudoku Background
Sudoku is a game played on a 9x9 grid. The goal of the game is to fill all cells of the grid with digits from 1 to 9, so that each column, each row, and each of the nine 3x3 sub-grids (also known as blocks) contain all of the digits from 1 to 9.
(More info at: http://en.wikipedia.org/wiki/Sudoku)

Sudoku Solution Validator
Write a function validSolution/ValidateSolution/valid_solution() that accepts a 2D array representing a Sudoku board, and returns true if it is a valid solution, or false otherwise. The cells of the sudoku board may also contain 0's, which will represent empty cells. Boards containing one or more zeroes are considered to be invalid solutions.

The board is always 9 cells by 9 cells, and every cell only contains integers from 0 to 9.
*/

use std::collections::HashSet;

fn valid_solution(sudoku: &[[u8;9]; 9]) -> bool {
    let mut is_ok;
    
    for i in 0..9 {
        is_ok = hor(*sudoku, i);
        if !is_ok {
            return false;
        }
        is_ok = ver(*sudoku, i);
        if !is_ok {
            return false;
        }
    }    

    is_ok = sqr(*sudoku);
    if !is_ok {
        return false;
    }
    
    return true;
}


fn hor(sudoku: [[u8; 9]; 9], pos: u8) -> bool {    
    let line = sudoku[pos as usize];
    let mut hset = HashSet::new();
    
    for i in line {
        if (i == 0) {
            return false;
        }
        hset.insert(i);
    }
    
    return hset.len() == 9;
}

fn ver(sudoku: [[u8; 9]; 9], pos: u8) -> bool {
    let mut hset = HashSet::new();    
    
    for i in 0..9 {
        hset.insert(sudoku[i as usize][pos as usize]);
    }
        
    return hset.len() == 9;
}


fn sqr(sudoku: [[u8; 9]; 9]) -> bool {
    let mut hset = HashSet::new();    
    
    for i in 0..3 {
        for j in 0..3 {            
            hset.insert(sudoku[i as usize][j as usize]);
            hset.insert(sudoku[i as usize][j +1 as usize]);
            hset.insert(sudoku[i as usize][j +2 as usize]);
            
            hset.insert(sudoku[i+1 as usize][j as usize]);
            hset.insert(sudoku[i+1 as usize][j +1 as usize]);
            hset.insert(sudoku[i+1 as usize][j +2 as usize]);
            
            hset.insert(sudoku[i+2 as usize][j as usize]);
            hset.insert(sudoku[i+2 as usize][j +1 as usize]);
            hset.insert(sudoku[i+2 as usize][j +2 as usize]);
            
            if hset.len() != 9 {
                return false;
            }
        }
    }
        
    return true;
}
