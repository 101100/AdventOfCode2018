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
    open System.Text.RegularExpressions

    let parse pattern input =
        let m = Regex.Match(input, pattern)
        if m.Success then Some(List.tail [ for g in m.Groups -> g.Value ])
        else None

    let splitLinesSkipBlank (input: string) =
        input.Split '\n'
        |> Seq.map (fun s -> s.Trim '\r')
        |> Seq.filter (fun s -> s.Length > 0)

    let splitLine characters (input: string) =
        input.Split characters
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
        input
        |> Util.splitLinesSkipBlank
        |> Seq.allPairs
        |> Seq.find ((<||) oneLetterDifferent)
        ||> Seq.zip
        |> Seq.filter ((<||) (=))
        |> Seq.map (fst >> string)
        |> String.concat ""


module Day3 =
    type Patch = { id: int; x: int; y: int; width: int; height: int }

    let parsePatches input =
        input
        |> Util.splitLinesSkipBlank
        |> Seq.map (Util.splitLine [|' '; '#'; '@'; ','; ':'; 'x'|])
        |> Seq.map (List.ofSeq >> List.map int)
        |> Seq.map (fun values ->
            match values with
            | [ id; x; y; w; h ] -> Some({id = id; x = x; y = y; width = w; height = h})
            | _ -> None)
        |> Seq.choose id

    let part1 input =
        input
        |> parsePatches
        |> Seq.map (fun patch -> seq { for x in patch.x .. patch.x + patch.width - 1 do for y in patch.y .. patch.y + patch.height - 1 do yield x, y })
        |> Seq.concat
        |> Seq.groupBy id
        |> Seq.filter (snd >> Seq.length >> (<) 1)
        |> Seq.length

    let part2 input =
        let patches =
            input
            |> parsePatches

        let idsWithOverlap =
            patches
            |> Seq.map (fun patch -> seq { for x in patch.x .. patch.x + patch.width - 1 do for y in patch.y .. patch.y + patch.height - 1 do yield x, y, patch.id })
            |> Seq.concat
            |> Seq.groupBy (fun (x, y, id) -> x, y)
            |> Seq.map snd
            |> Seq.filter (Seq.length >> (<) 1)
            |> Seq.concat
            |> Seq.map (fun (x, y, id) -> id)
            |> Set.ofSeq

        patches
        |> Seq.find (fun patch -> not (Set.contains patch.id idsWithOverlap))
        |> (fun patch -> patch.id)
