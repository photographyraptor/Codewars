/*
Your task, is to create a NxN spiral with a given size.

For example, spiral with size 5 should look like this:

00000
....0
000.0
0...0
00000

0000000000
.........0
00000000.0
0......0.0
0.0000.0.0
0.0..0.0.0
0.0....0.0
0.000000.0
0........0
0000000000

*/

//TODO:


fn spiralize(size: usize) -> Vec<Vec<i8>> {
    let mut v = matrix(size);
    let mut w: Vec<Vec<Vec<usize>>> = Vec::new();
    
    for line in 0..size {
        if (line+1) % 4 == 0 { //arriba
            w.push([6, 7].to_vec());
        } else if (line+1) % 3 == 0 { //izquierda
            w.push([4, 5].to_vec());
        } else if (line+1) % 2 == 0 { //abajo
            w.push([2, 3].to_vec());
        } else { //derecha            
            w.push([0, 1].to_vec());
        }
    }
    
    for w1 in w {
        for w2 in w1 {
            for w3 im w2 {
                print!("{},", w3);
            }
        }
    }
        
    return v;
}



fn posToPrint(line: usize, size: usize) -> Vec<Vec<i8>> {    
    let mut v: Vec<Vec<usize>> = Vec::new();
    let l = lineLength(line, size);
    
    
    return v;
}

fn lineLength(line: usize, size: usize) -> usize {
    if line < 4 {
        return size;
    }
    
}



fn matrix(size: usize) -> Vec<Vec<i8>> {
    let mut v: Vec<Vec<i8>> = Vec::new();
    
    for rowPos in 0..size {
        v.push(row(rowPos, size));
    }
    
    return v;
}

fn row(rowPos: usize, size: usize) -> Vec<i8> {
    let mut v: Vec<i8> = Vec::new();    
    
    for colPos in 0..size {
        v.push(0);
    }
    
    return v;
}