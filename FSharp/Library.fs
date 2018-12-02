namespace AdventOfCode2018.FSharp


module Seq =
    let repeat items =
        seq { while true do yield! items }

    let allPairs items =
        items
        |> Seq.mapi (fun index1 item1 -> (Seq.mapi (fun index2 item2 -> if index1 = index2 then None else Some(item1, item2)) items))
        |> Seq.concat
        |> Seq.choose id


module Util =
    let splitLinesSkipBlank (input: string) =
        Seq.toList (input.Split '\n')
        |> Seq.map (fun s -> s.Trim '\r')
        |> Seq.filter (fun s -> s.Length > 0)


module Day1 =
    let frequencies input =
        input
        |> Util.splitLinesSkipBlank
        |> Seq.map int

    let part1 input =
        input
        |> frequencies
        |> Seq.sum

    let part2 input =
        input
        |> frequencies
        |> Seq.repeat
        |> Seq.scan (+) 0
        |> Seq.scan (fun (set, repeat) next -> if Set.contains next set then set, Some(next) else (Set.add next set), None) (Set.empty, None)
        |> Seq.pick snd


module Day2 =
    let letterCounts line =
        line
        |> Seq.groupBy id
        |> Seq.map (snd >> Seq.length)
        |> Set.ofSeq

    let part1 input =
        input
        |> Util.splitLinesSkipBlank
        |> Seq.map letterCounts
        |> Seq.fold
            (fun (twos, threes) counts ->
                twos + (if Set.contains 2 counts then 1 else 0),
                threes  + (if Set.contains 3 counts then 1 else 0))
            (0, 0)
        |> fun (twos, threes) -> twos * threes

    let oneLetterDifferent first second =
        Seq.zip first second
        |> Seq.filter ((<||) (<>))
        |> Seq.length
        |> (=) 1

    let part2 input =
        let pair =
            input
            |> Util.splitLinesSkipBlank
            |> Seq.allPairs
            |> Seq.find ((<||) oneLetterDifferent)

        Seq.zip <|| pair
        |> Seq.filter ((<||) (=))
        |> Seq.map fst
        |> Seq.map string
        |> String.concat ""
