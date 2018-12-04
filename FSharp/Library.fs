namespace AdventOfCode2018.FSharp


module Seq =
    let allPairs items =
        Seq.allPairs items items

    let repeat items =
        seq { while true do yield! items }


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
    type Patch = { Id: int; X: int; Y: int; Width: int; Height: int }

    let parsePatches input =
        input
        |> Util.splitLinesSkipBlank
        |> Seq.map (Util.splitLine [|' '; '#'; '@'; ','; ':'; 'x'|])
        |> Seq.map (List.ofSeq >> List.map int)
        |> Seq.map (fun values ->
            match values with
            | [ id; x; y; w; h ] -> Some({Id = id; X = x; Y = y; Width = w; Height = h})
            | _ -> None)
        |> Seq.choose id

    let part1 input =
        input
        |> parsePatches
        |> Seq.collect (fun patch -> seq { for x in patch.X .. patch.X + patch.Width - 1 do for y in patch.Y .. patch.Y + patch.Height - 1 do yield x, y })
        |> Seq.groupBy id
        |> Seq.filter (snd >> Seq.length >> (<) 1)
        |> Seq.length

    let part2 input =
        let patches =
            input
            |> parsePatches

        let idsWithOverlap =
            patches
            |> Seq.collect (fun patch -> seq { for x in patch.X .. patch.X + patch.Width - 1 do for y in patch.Y .. patch.Y + patch.Height - 1 do yield x, y, patch.Id })
            |> Seq.groupBy (fun (x, y, id) -> x, y)
            |> Seq.map snd
            |> Seq.filter (Seq.length >> (<) 1)
            |> Seq.concat
            |> Seq.map (fun (x, y, id) -> id)
            |> Set.ofSeq

        patches
        |> Seq.find (fun patch -> not (Set.contains patch.Id idsWithOverlap))
        |> (fun patch -> patch.Id)


module Day4 =
    open System

    type Activity = { Timestamp: DateTime; Activity: string; Guard: int }
    type Nap = { Guard: int; Start: int; End: int }

    let parseNaps input =
        input
        |> Util.splitLinesSkipBlank
        |> Seq.sort
        |> Seq.map (fun line -> {
            Timestamp = DateTime.Parse (line.Substring (1, 16));
            Activity = if line.[19] = 'G' then "start" elif line.[19] = 'f' then "sleep" else "wake";
            Guard = if line.[19] = 'G' then int ((line.Substring 26).Split ' ').[0] else -1
        })
        |> Seq.scan
            (fun last next ->
                if next.Guard <> -1 then next else { next with Guard = last.Guard })
            { Timestamp = DateTime.MinValue; Activity = "dummy"; Guard = -1 }
        |> Seq.pairwise
        |> Seq.filter (fst >> (fun activity -> activity.Activity = "sleep"))
        |> Seq.map (fun (startActivity, endActivity) -> {
            Guard = startActivity.Guard;
            Start = if startActivity.Timestamp.Hour = 0 then startActivity.Timestamp.Minute else 0;
            End = if endActivity.Guard = startActivity.Guard && endActivity.Timestamp.Hour = 0 then endActivity.Timestamp.Minute - 1 else 59
        })

    let part1 input =
        let naps =
            input
            |> parseNaps

        let sleepyGuard =
            naps
            |> Seq.groupBy (fun nap -> nap.Guard)
            |> Seq.map (fun (guard, naps) -> guard, Seq.sum (Seq.map (fun nap -> nap.End - nap.Start + 1) naps))
            |> Seq.sortByDescending snd
            |> Seq.head
            |> fst

        let sleepyMinuteForSleepyGuard =
            naps
            |> Seq.filter (fun nap -> nap.Guard = sleepyGuard)
            |> Seq.collect (fun nap -> { nap.Start .. nap.End })
            |> Seq.groupBy id
            |> Seq.map (fun (minute, minutes) -> minute, Seq.length minutes)
            |> Seq.sortByDescending snd
            |> Seq.head
            |> fst

        sleepyGuard * sleepyMinuteForSleepyGuard

    let part2 input =
        input
        |> parseNaps
        |> Seq.collect (fun nap -> seq { for min in nap.Start .. nap.End -> nap.Guard, min })
        |> Seq.groupBy id
        |> Seq.map (fun (guardMinute, minutes) -> guardMinute, Seq.length minutes)
        |> Seq.sortByDescending snd
        |> Seq.head
        |> fst
        ||> (*)
