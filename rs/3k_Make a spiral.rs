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

fn spiralize(size: usize) -> Vec<Vec<i8>> {
    let mut v = matrix(size);
    let mut w: Vec<Vec<Vec<usize>>> = Vec::new();
    w.push(vec![vec![0, 0]]);
    let mut vsize = size;
    let mut dir = '>';
    
    for line in 0..size {
        
        if dir == '>' {            
            w.push(derecha(vsize, w.last().unwrap().last().unwrap().to_vec()));
            dir = 'v';
        }
        else if dir == 'v' {
            if line >= 3 {
                vsize = vsize -2;
            }
            w.push(abajo(vsize, w.last().unwrap().last().unwrap().to_vec()));
            dir = '<';
        } else if dir == '<' {
            w.push(izquierda(vsize, w.last().unwrap().last().unwrap().to_vec()));
            dir = '^';
        } else {
            vsize = vsize -2;
            w.push(arriba(vsize, w.last().unwrap().last().unwrap().to_vec()));
            dir = '>';        
        }
    }
    
    for w1 in w {
        for w2 in w1 {
            v[w2[0]][w2[1]] = 1;
        }
    }
        
    return v;
}

fn derecha(vsize: usize, lastpos: Vec<usize>) -> Vec<Vec<usize>> {    
    let mut v: Vec<Vec<usize>> = Vec::new();
    let mut p = lastpos[1];
    
    for _i in 0..vsize-1 {
        p = p +1;
        v.push([lastpos[0], p].to_vec())
    }    
    
    return v;
}

fn abajo(vsize: usize, lastpos: Vec<usize>) -> Vec<Vec<usize>> {    
    let mut v: Vec<Vec<usize>> = Vec::new();
    let mut p = lastpos[0];
    
    for _i in 0..vsize-1 {
        p = p +1;
        v.push([p, lastpos[1]].to_vec())
    }    
    
    return v;
}

fn izquierda(vsize: usize, lastpos: Vec<usize>) -> Vec<Vec<usize>> {    
    let mut v: Vec<Vec<usize>> = Vec::new();
    let mut p = lastpos[1];
    
    for _i in 0..vsize-1 {
        if p == 0 {
            return v;
        }
        p = p -1;
        v.push([lastpos[0], p].to_vec())
    }    
    
    return v;
}

fn arriba(vsize: usize, lastpos: Vec<usize>) -> Vec<Vec<usize>> {    
    let mut v: Vec<Vec<usize>> = Vec::new();
    let mut p = lastpos[0];
    
    for _i in 0..vsize-1 {
        if p == 0 {
            return v;
        }
        p = p -1;
        v.push([p, lastpos[1]].to_vec())
    }    
    
    return v;
}

fn matrix(size: usize) -> Vec<Vec<i8>> {
    let mut v: Vec<Vec<i8>> = Vec::new();
    
    for _i in 0..size {
        v.push(row(size));
    }
    
    return v;
}

fn row(size: usize) -> Vec<i8> {
    let mut v: Vec<i8> = Vec::new();    
    
    for _i in 0..size {
        v.push(0);
    }
    
    return v;
}