//In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". Your function receives one side of the DNA (string, except for Haskell); you need to return the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

fn dna_strand(dna: &str) -> String {
    let mut res = String::new();
    for d in dna.chars(){
        res.push(dna_strand_c(d));
    }
    return res;
}

fn dna_strand_c(c: char) -> char {
    if c == 'A' {
        return 'T';
    }
    else if c == 'T' {
        return 'A';
    }
    else if c == 'C' {
        return 'G';
    }
    else if c == 'G' {
        return 'C';
    }
    else {
        return '-';
    }
}