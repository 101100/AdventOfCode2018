namespace AdventOfCode2018.FSharp


module Seq =
    let repeat items =
        seq { while true do yield! items }


module Util =
    let splitLinesSkipBlank (input: string) =
        Seq.toList (input.Split '\n')
        |> Seq.map (fun s -> s.Trim '\r')
        |> Seq.filter (fun s -> s.Length > 0)


module Day1 =
    let frequencies input =
        input
        |> Util.splitLinesSkipBlank
        |> Seq.map (string >> int)

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
        |> Seq.pick (fun (set, repeat) -> repeat)
