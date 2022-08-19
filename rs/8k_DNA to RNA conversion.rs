//Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').

//Create a function which translates a given DNA string into RNA.

fn dna_to_rna(dna: &str) -> String {    
    let mut res = String::new();
    for d in dna.chars(){
        if d == 'T' {
            res.push('U');
        }
        else {
            res.push(d);
        }
    }
    return res;    
}