open System.IO

let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

let inputs = readLines "/Users/lucapangerc/workspace/AoC2022/Day1/inputs/test_input.txt"
let printSeq seq1 = Seq.iter (printf "%A ") seq1

printSeq inputs