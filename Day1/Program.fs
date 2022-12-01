module Day1

open System.IO
open FSharpPlus

let readLines (filePath: string) =
    seq {
        use sr = new StreamReader(filePath)

        while not sr.EndOfStream do
            yield sr.ReadLine()
    }

let calories =
    readLines (__SOURCE_DIRECTORY__ + "/inputs/real_input.txt")

let splitCalories =
    calories
    |> Seq.split [ [ "" ] ]
    |> Seq.map (Seq.map int)

let sumCalories =
    splitCalories |> Seq.map Seq.sum

let sortedSumCalories =
    sumCalories |> Seq.sortDescending

let highest = sortedSumCalories |> Seq.head
printfn $"Highest: %i{highest}"

let highest3 = sortedSumCalories |> Seq.take 3 |> Seq.sum
printf $"Highest_3: %i{highest3}"
