using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

using AdventOfCode2018.FSharp;

namespace AdventOfCode2018.CSharp
{

    public static class Program
    {

        private static void Main(string[] args)
        {
            var dayString = args.Length >= 1
                ? args[0]
                : Program.ReadDay();

            if (!byte.TryParse(dayString, out var day))
            {
                Console.WriteLine($"I've never heard of day '{dayString}', sorry.");
                return;
            }

            if (day == 1)
            {
                var input = Inputs.GetInput(1);

                Console.WriteLine($"Part 1 (C#): {Program.Day1Part1(input)}");
                Console.WriteLine($"Part 1 (F#): {Day1.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day1Part2(input)}");
                Console.WriteLine($"Part 2 (F#): {Day1.part2(input)}");
            }
            else if (day == 2)
            {
                var input = Inputs.GetInput(2);

                Console.WriteLine($"Part 1 (C#): {Program.Day2Part1(input)}");
                Console.WriteLine($"Part 1 (F#): {Day2.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day2Part2(input)}");
                Console.WriteLine($"Part 2 (F#): {Day2.part2(input)}");
            }
            else if (day == 3)
            {
                var input = Inputs.GetInput(3);

                Console.WriteLine($"Part 1 (C#): {Program.Day3Part1(input)}");
                Console.WriteLine($"Part 1 (F#): {Day3.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day3Part2(input)}");
                Console.WriteLine($"Part 2 (F#): {Day3.part2(input)}");
            }
            else if (day == 4)
            {
                var input = Inputs.GetInput(4);

                Console.WriteLine($"Part 1 (C#): {Program.Day4Part1(input)}");
                Console.WriteLine($"Part 1 (F#): {Day4.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day4Part2(input)}");
                Console.WriteLine($"Part 2 (F#): {Day4.part2(input)}");
            }
            else if (day == 5)
            {
                var input = Inputs.GetInput(5);

                Console.WriteLine($"Part 1 (C#): {Program.Day5Part1(input)}");
                Console.WriteLine($"Part 1 (F#): {Day5.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day5Part2(input)}");
                Console.WriteLine($"Part 2 (F#): {Day5.part2(input)}");
            }
            else if (day == 6)
            {
                var input = Inputs.GetInput(6);

                Console.WriteLine($"Part 1 (C#): {Program.Day6Part1(input)}");
                Console.WriteLine($"Part 1 (F#): {Day6.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day6Part2(input)}");
                Console.WriteLine($"Part 2 (F#): {Day6.part2(input)}");
            }
            else if (day == 7)
            {
                var input = Inputs.GetInput(7);

                Console.WriteLine($"Part 1 (C#): {Program.Day7Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day7.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day7Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day7.part2(input)}");
            }
            else if (day == 8)
            {
                var input = Inputs.GetInput(8);

                Console.WriteLine($"Part 1 (C#): {Program.Day8Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day8.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day8Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day8.part2(input)}");
            }
            else if (day == 9)
            {
                var input = Inputs.GetInput(9);
                var inputParts = input.Split(" ");
                var players = int.Parse(inputParts[0]);
                var lastMarble = int.Parse(inputParts[6]);

                Console.WriteLine($"Part 1 (C#): {Program.Day9Part1(players, lastMarble)}");
//                Console.WriteLine($"Part 1 (F#): {Day9.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day9Part2(players, lastMarble)}");
//                Console.WriteLine($"Part 2 (F#): {Day9.part2(input)}");
            }
            else if (day == 10)
            {
                var input = Inputs.GetInput(10);

                Console.WriteLine($"Part 1 (C#): {Program.Day10Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day10.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day10Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day10.part2(input)}");
            }
            else if (day == 11)
            {
                var input = 5791;

                Console.WriteLine($"Part 1 (C#): {Program.Day11Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day11.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day11Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day11.part2(input)}");
            }
            else if (day == 12)
            {
                var input = Inputs.GetInput(12);

                Console.WriteLine($"Part 1 (C#): {Program.Day12Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day12.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day12Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day12.part2(input)}");
            }
            else if (day == 13)
            {
                var input = Inputs.GetInput(13);

                Console.WriteLine($"Part 1 (C#): {Program.Day13Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day13.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day13Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day13.part2(input)}");
            }
            else if (day == 14)
            {
                var input = "030121";

                Console.WriteLine($"Part 1 (C#): {Program.Day14Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day14.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day14Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day14.part2(input)}");
            }
            else if (day == 15)
            {
                var input = Inputs.GetInput(15);

                Console.WriteLine($"Part 1 (C#): {Program.Day15Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day15.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day15Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day15.part2(input)}");
            }
            else if (day == 16)
            {
                var input = Inputs.GetInput(16);

                Console.WriteLine($"Part 1 (C#): {Program.Day16Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day16.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day16Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day16.part2(input)}");
            }
            else if (day == 17)
            {
                var input = Inputs.GetInput(17);
                var cSharpOutput = Program.Day17(input);

                Console.WriteLine($"Part 1 (C#): {cSharpOutput.Part1}");
//                Console.WriteLine($"Part 1 (F#): {Day17.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {cSharpOutput.Part2}");
//                Console.WriteLine($"Part 2 (F#): {Day17.part2(input)}");
            }
            else if (day == 18)
            {
                var input = Inputs.GetInput(18);

                Console.WriteLine($"Part 1 (C#): {Program.Day18Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day18.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day18Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day18.part2(input)}");
            }
            else if (day == 19)
            {
                var input = Inputs.GetInput(19);

                Console.WriteLine($"Part 1 (C#): {Program.Day19Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day19.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day19Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day19.part2(input)}");
            }
            else if (day == 20)
            {
                var input = Inputs.GetInput(20);

                Console.WriteLine($"Part 1 (C#): {Program.Day20Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day20.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day20Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day20.part2(input)}");
            }
            else if (day == 21)
            {
                var input = Inputs.GetInput(21);

                Console.WriteLine($"Part 1 (C#): {Program.Day21Part1(input)}");
//                Console.WriteLine($"Part 1 (F#): {Day21.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day21Part2(input)}");
//                Console.WriteLine($"Part 2 (F#): {Day21.part2(input)}");
            }
            else if (day == 22)
            {
                var depth = 11739;
                var target = (X: 11, Y: 718);

                Console.WriteLine($"Part 1 (C#): {Program.Day22Part1(depth, target)}");
//                Console.WriteLine($"Part 1 (F#): {Day22.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day22Part2(depth, target)}");
//                Console.WriteLine($"Part 2 (F#): {Day22.part2(input)}");
            }
            else
            {
                Console.WriteLine($"I've never heard of day '{day}', sorry.");
            }
        }


        private static string ReadDay()
        {
            Console.Write("Run what day: ");
            return Console.ReadLine();
        }


        private static int Day1Part1(string input)
        {
            return input
                .SelectLines()
                .Select(int.Parse)
                .Sum();
        }


        private static int Day1Part2(string input)
        {
            var rawInput = input
                .SelectLines();
            var values = rawInput
                .Repeat()
                .Select(int.Parse)
                .Scan(0, (next, last) => next + last);

            var seen = ImmutableHashSet<int>.Empty;
            foreach (var freq in values)
            {
                if (freq != 0 && seen.Contains(freq))
                {
                    return freq;
                }

                seen = seen.Add(freq);
            }

            return 0;
        }


        private static int Day2Part1(string input)
        {
            var counts = input
                .SelectLines()
                .Aggregate((TwoCount: 0, ThreeCount: 0), (oldCounts, nextString) =>
                {
                    var letterCounts = Program.Day2CountLetters(nextString);
                    return (
                        oldCounts.TwoCount + (letterCounts.Any(p => p.Value == 2) ? 1 : 0),
                        oldCounts.ThreeCount + (letterCounts.Any(p => p.Value == 3) ? 1 : 0));
                });

            return counts.TwoCount * counts.ThreeCount;
        }


        private static ImmutableDictionary<char, int> Day2CountLetters(string input)
        {
            return input
                .GroupBy(c => c)
                .ToImmutableDictionary(g => g.Key, g => g.Count());
        }


        private static string Day2Part2(string input)
        {
            var different = input
                .SelectLines()
                .AllPairs()
                .First(Program.Day2OneLetterDifferent);

            return new string(different.Item1
                .Zip(different.Item2, (left, right) => (Left: left, Right: right))
                .Where(t => t.Left == t.Right)
                .Select(t => t.Left)
                .ToArray());
        }


        private static bool Day2OneLetterDifferent((string, string) inputPair)
        {
            return inputPair.Item1
                .Zip(inputPair.Item2, (left, right) => (Left: left, Right: right))
                .Count(t => t.Left != t.Right) == 1;
        }


        private static int Day3Part1(string input)
        {
            return Program.Day3ReadPatches(input)
                .SelectMany(t => Enumerable.Range(t.X, t.Width).SelectMany(x => Enumerable.Range(t.Y, t.Height).Select(y => (x, y))))
                .GroupBy(t => t)
                .Count(t => t.Count() > 1);
        }


        private static IEnumerable<(int Id, int X, int Y, int Width, int Height)> Day3ReadPatches(string input)
        {
            return input
                .SelectLines()
                .Select(line => line.Split(' ', '#', '@', ',', ':', 'x').Where(s => s.Length > 0).ToArray())
                .Select(parts => (
                    Id: int.Parse(parts[0]),
                    X: int.Parse(parts[1]),
                    Y: int.Parse(parts[2]),
                    Width: int.Parse(parts[3]),
                    Height: int.Parse(parts[4])));
        }


        private static int Day3Part2(string input)
        {
            var patches = Program.Day3ReadPatches(input)
                .ToImmutableArray();

            var positionsWithOverlap = patches
                .SelectMany(t => Enumerable.Range(t.X, t.Width).SelectMany(x => Enumerable.Range(t.Y, t.Height).Select(y => (x, y))))
                .GroupBy(t => t)
                .Where(t => t.Count() > 1)
                .Select(t => t.Key)
                .ToImmutableHashSet();

            return patches
                .First(
                    t => !Enumerable.Range(t.X, t.Width)
                        .SelectMany(x => Enumerable.Range(t.Y, t.Height).Select(y => (x, y)))
                        .Any(pos => positionsWithOverlap.Contains(pos)))
                .Id;
        }


        private static int Day4Part1(string input)
        {
            var naps = Program.Day4ParseGuardNaps(input);

            var sleepyGuard = naps
                .GroupBy(s => s.Guard, s => s.End - s.Start + 1)
                .Select(g => (
                    Guard: g.Key,
                    Hours: g.Sum()))
                .OrderByDescending(t => t.Hours)
                .First()
                .Guard;

            var sleepyMinuteForSleepyGuard = naps
                .Where(s => s.Guard == sleepyGuard)
                .SelectMany(s => Enumerable.Range(s.Start, s.End - s.Start + 1))
                .GroupBy(h => h)
                .Select(g => (
                    Minute: g.Key,
                    Count: g.Count()
                ))
                .OrderByDescending(t => t.Count)
                .First()
                .Minute;

            return sleepyGuard * sleepyMinuteForSleepyGuard;
        }


        private static ImmutableArray<(int Guard, int Day, int Start, int End)> Day4ParseGuardNaps(string input)
        {
            return input
                .SelectLines()
                .OrderBy(s => s)
                .Select(s => (
                    Timestamp: DateTime.Parse(s.Substring(1, 16)),
                    Activity: s[19] == 'G' ? "start" : s[19] == 'f' ? "sleep" : "wake",
                    Guard: s[19] == 'G' ? int.Parse(s.Substring(26).Split(' ')[0]) : default(int?)
                ))
                .Scan((Timestamp: DateTime.MinValue, Activity: string.Empty, Guard: -1), (acc, next) => (
                    next.Timestamp,
                    next.Activity,
                    next.Guard ?? acc.Guard))
                .PairWise()
                .Where(p => p.Item1.Activity == "sleep")
                .Select(pair => (
                    Guard: pair.Item1.Guard,
                    Day: pair.Item1.Timestamp.Hour == 23 ? pair.Item1.Timestamp.Day + 1 : pair.Item1.Timestamp.Day,
                    Start: pair.Item1.Timestamp.Hour == 0 ? pair.Item1.Timestamp.Minute : 0,
                    End: pair.Item2.Guard == pair.Item1.Guard && pair.Item2.Timestamp.Hour == 0 ? pair.Item2.Timestamp.Minute - 1 : 59
                ))
                .ToImmutableArray();
        }


        private static int Day4Part2(string input)
        {
            var sleepyGuardMinute = Program
                .Day4ParseGuardNaps(input)
                .SelectMany(s => Enumerable.Range(s.Start, s.End - s.Start + 1)
                    .Select(m => (
                        Guard: s.Guard,
                        Minute: m)
                    ))
                .GroupBy(t => t)
                .Select(g => (
                    Guard: g.Key.Guard,
                    Minute: g.Key.Minute,
                    Count: g.Count()
                ))
                .OrderByDescending(t => t.Count)
                .First();

            return sleepyGuardMinute.Guard * sleepyGuardMinute.Minute;
        }


        private static int Day5Part1(string input)
        {
            var polymer = Program.Day25ReadPolymer(input);

            return polymer.Day5FindFinalLength();
        }


        private static ImmutableArray<(int Char, bool Little)> Day25ReadPolymer(string input)
        {
            return input
                .Trim()
                .Select(ch =>
                {
                    var little = ch >= 'a' && ch <= 'z';
                    return (
                        Char: ch - (little ? 'a' : 'A'),
                        Little: little);
                })
                .ToImmutableArray();
        }


        private static int Day5FindFinalLength(this IEnumerable<(int Char, bool Little)> characters)
        {
            var result = Program.Day5Trigger(characters);
            while (result.Removed)
            {
                result = Program.Day5Trigger(result.Next);
            }

            return result.Next.Count;
        }


        private static (List<(int, bool)> Next, bool Removed) Day5Trigger(IEnumerable<(int Char, bool Little)> characters)
        {
            var output = new List<(int, bool)>();
            var last = (Char: -1, Little: true);
            var removed = false;
            foreach (var next in characters)
            {
                if (last.Char == -1)
                {
                    last = next;
                }
                else
                {
                    if (last.Char == next.Char && last.Little != next.Little)
                    {
                        last = (Char: -1, Little: true);
                        removed = true;
                    }
                    else
                    {
                        output.Add(last);
                        last = next;
                    }
                }
            }

            if (last.Char != -1)
            {
                output.Add(last);
            }

            return (output, removed);
        }


        private static int Day5Part2(string input)
        {
            var characters = Program.Day25ReadPolymer(input);

            return characters
                .Select(u => u.Char)
                .Distinct()
                .Select(ch => characters.Where(t => t.Char != ch).Day5FindFinalLength())
                .Min();
        }


        private static int Day6Part1(string input)
        {
            var positions = input
                .SelectLines()
                .Select(line => line.Split(", "))
                .Select((parts, index) => (X: int.Parse(parts[0]), Y: int.Parse(parts[1]), Index: index))
                .ToImmutableArray();

            var minX = positions
                .Select(t => t.X)
                .Min();

            var minY = positions
                .Select(t => t.Y)
                .Min();

            var maxX = positions
                .Select(t => t.X)
                .Max();

            var maxY = positions
                .Select(t => t.Y)
                .Max();

            var infiniteOnes = new[] {minX - 1, maxX + 1}
                .SelectMany(x => Enumerable.Range(minY, maxY - minY + 1).Select(y => (X: x, Y: y)))
                .Concat(new[] {minY - 1, maxY + 1}
                    .SelectMany(y => Enumerable.Range(minX, maxX - minX + 1).Select(x => (X: x, Y: y))))
                .Select(pos => pos.Day6FindClosest(positions))
                .Where(t => t.Index.HasValue)
                .Select(t => t.Index)
                .ToImmutableHashSet();

            return Enumerable.Range(minX, maxX - minX + 1)
                .SelectMany(x => Enumerable.Range(minY, maxY - minY + 1).Select(y => (X: x, Y: y)))
                .Select(pos => pos.Day6FindClosest(positions))
                .Where(t => t.Index.HasValue)
                .GroupBy(t => t.Index)
                .Where(g => g.Key.HasValue && !infiniteOnes.Contains(g.Key.Value))
                .OrderByDescending(g => g.Count())
                .First()
                .Count();
        }


        private static (int? Distance, int? Index) Day6FindClosest(this (int X, int Y) pos, ImmutableArray<(int X, int Y, int Index)> possibilities)
        {
            return possibilities
                .Select(thing => (Distance: Math.Abs(pos.X - thing.X) + Math.Abs(pos.Y - thing.Y), Index: thing.Index))
                .OrderBy(t => t.Distance)
                .PairWise()
                .Select(t => t.Item1.Distance == t.Item2.Distance ? (default(int?), default(int?)) : (t.Item1.Distance, t.Item1.Index))
                .First();
        }


        private static int Day6Part2(string input)
        {
            var positions = input
                .SelectLines()
                .Select(line => line.Split(", "))
                .Select((parts, index) => (X: int.Parse(parts[0]), Y: int.Parse(parts[1]), Index: index))
                .ToImmutableArray();

            var minX = positions
                .Select(t => t.X)
                .Min();

            var minY = positions
                .Select(t => t.Y)
                .Min();

            var maxX = positions
                .Select(t => t.X)
                .Max();

            var maxY = positions
                .Select(t => t.Y)
                .Max();

            return Enumerable.Range(minX, maxX - minX + 1)
                .SelectMany(x => Enumerable.Range(minY, maxY - minY + 1).Select(y => (X: x, Y: y)))
                .Select(pos => pos.Day6FindTotalDistance(positions))
                .Count(d => d < 10000);
        }


        private static int Day6FindTotalDistance(this (int X, int Y) pos, ImmutableArray<(int X, int Y, int Index)> possibilities)
        {
            return possibilities
                .Select(thing => Math.Abs(pos.X - thing.X) + Math.Abs(pos.Y - thing.Y))
                .Sum();
        }


        private static string Day7Part1(string input)
        {
            var requiredPredecessors = Program.Day7ReadRequiredPredecessors(input);

            var done = new List<char>();

            while (done.Count < requiredPredecessors.Count)
            {
                var next = Program.Day7GetNext(requiredPredecessors, done, done);

                done.Add(next);
            }

            return string.Join(string.Empty, done);
        }


        private static ImmutableDictionary<char, ImmutableArray<char>> Day7ReadRequiredPredecessors(string input)
        {
            var requiredPredecessors = input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(parts => (Prev: parts[1][0], Next: parts[7][0]))
                .GroupBy(t => t.Next)
                .ToImmutableDictionary(g => g.Key, g => g.Select(t => t.Prev).ToImmutableArray());

            var nodesWithoutPredecessors = requiredPredecessors
                .SelectMany(p => p.Value)
                .Where(c => !requiredPredecessors.ContainsKey(c));

            return requiredPredecessors
                .Concat(nodesWithoutPredecessors.Select(c => new KeyValuePair<char, ImmutableArray<char>>(c, ImmutableArray<char>.Empty)))
                .ToImmutableDictionary(p => p.Key, p => p.Value);
        }


        private static char Day7GetNext(IReadOnlyDictionary<char, ImmutableArray<char>> requiredPredecessors, ICollection<char> started, ICollection<char> finished)
        {
            return requiredPredecessors
                .Select(p => p.Key)
                .Where(ch => !started.Contains(ch))
                .OrderBy(c => c)
                .FirstOrDefault(ch => requiredPredecessors[ch].All(finished.Contains));
        }


        private static int Day7Part2(string input)
        {
            var requiredPredecessors = Program.Day7ReadRequiredPredecessors(input);

            var started = new HashSet<char>();
            var finished = new List<char>();

            var second = 0;
            var workers = Enumerable
                .Range(0, 5)
                .Select(_ => (Working: false, Task: ' ', RemaingTime: -1))
                .ToArray();
            while (finished.Count < requiredPredecessors.Count)
            {
                for (var i = 0; i < workers.Length; i++)
                {
                    if (workers[i].Working)
                    {
                        if (workers[i].RemaingTime == 0)
                        {
                            finished.Add(workers[i].Task);
                            workers[i] = (false, ' ', -1);
                        }
                        else
                        {
                            workers[i] = (workers[i].Working, workers[i].Task, workers[i].RemaingTime - 1);
                        }
                    }

                    if (!workers[i].Working)
                    {
                        var next = Program.Day7GetNext(requiredPredecessors, started, finished);
                        if (next != default(char))
                        {
                            workers[i] = (true, next, 60 + (next - 'A'));
                            started.Add(next);
                        }
                    }
                }

                Console.WriteLine($"{second:D4}\t{string.Join("\t", workers.Select(w => w.Task))} {string.Join(string.Empty, finished)}");

                second += 1;
            }

            return second - 1;
        }


        private static int Day8Part1(string input)
        {
            var parsedInput = input
                .Trim()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            return Program.Day8GetMetadata(parsedInput.GetEnumerator());
        }


        private static int Day8GetMetadata(IEnumerator<int> parsedInput)
        {
            parsedInput.MoveNext();
            var childCount = parsedInput.Current;
            parsedInput.MoveNext();
            var metadataCount = parsedInput.Current;

            var metadataTotal = 0;

            for (var child = 0; child < childCount; child++)
            {
                metadataTotal += Program.Day8GetMetadata(parsedInput);
            }

            for (var metadata = 0; metadata < metadataCount; metadata++)
            {
                parsedInput.MoveNext();
                metadataTotal += parsedInput.Current;
            }

            return metadataTotal;
        }


        private static int Day8Part2(string input)
        {
            var parsedInput = input
                .Trim()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            return Program.Day8GetCost(parsedInput.GetEnumerator());
        }


        private static int Day8GetCost(IEnumerator<int> parsedInput)
        {
            parsedInput.MoveNext();
            var childCount = parsedInput.Current;
            parsedInput.MoveNext();
            var metadataCount = parsedInput.Current;

            var children = Enumerable
                .Range(0, childCount)
                .Select(_ => Program.Day8GetCost(parsedInput))
                .ToImmutableArray();

            var metadata = Enumerable
                .Range(0, metadataCount)
                .Select(_ =>
                {
                    parsedInput.MoveNext();
                    return parsedInput.Current;
                })
                .ToImmutableArray();


            return childCount == 0
                ? metadata.Sum()
                : metadata.Sum(m => children.Length >= m ? children[m - 1] : 0);
        }


        private static int Day9Part1(int players, int lastMarble)
        {
            var circle = new List<int>(70000) {0};

            var currentIndex = 0;
            var nextPlayer = 0;
            var scores = Enumerable
                .Range(0, players)
                .Select(_ => 0)
                .ToArray();

            foreach(var marble in Enumerable.Range(1, lastMarble))
            {
                if (marble % 23 == 0)
                {
                    var toRemoveIndex = (currentIndex - 7 + circle.Count) % circle.Count;
                    scores[nextPlayer] += (marble + circle[toRemoveIndex]);
                    circle.RemoveAt(toRemoveIndex);
                    currentIndex = toRemoveIndex;
                }
                else
                {
                    var nextIndex = (currentIndex + 1) % circle.Count;
                    circle.Insert(nextIndex + 1, marble);
                    currentIndex = nextIndex + 1;
                }

                nextPlayer = (nextPlayer + 1) % players;
            }

            return scores.Max();
        }


        private static long Day9Part2(int players, int lastMarble)
        {
            var circle = new LinkedList<int>();
            circle.AddLast(0);

            var currentNode = circle.First ?? throw new InvalidOperationException("The list can't be empty here.");
            var nextPlayer = 0;
            var scores = Enumerable
                .Range(0, players)
                .Select(_ => 0L)
                .ToArray();

            foreach(var marble in Enumerable.Range(1, lastMarble * 100))
            {
                if (marble % 23 == 0)
                {
                    for (var i = 0; i < 7; i++)
                    {
                        currentNode = currentNode.Previous ?? circle.Last ?? throw new InvalidOperationException("The list can't be empty here.");
                    }
                    scores[nextPlayer] += (marble + currentNode.Value);
                    var toRemoveNode = currentNode;
                    currentNode = currentNode.Next ?? circle.First ?? throw new InvalidOperationException("The list can't be empty here.");
                    circle.Remove(toRemoveNode);
                }
                else
                {
                    currentNode = currentNode.Next ?? circle.First ?? throw new InvalidOperationException("The list can't be empty here.");
                    circle.AddAfter(currentNode, marble);
                    currentNode = currentNode.Next ?? throw new InvalidOperationException("We just added a node, so this should work.");
                }

                nextPlayer = (nextPlayer + 1) % players;
            }

            return scores.Max();
        }


        private static string Day10Part1(string input)
        {
            var startingState = input
                .SelectLines()
                .Select(s => s.Split("<"))
                .Select(parts => (parts[1].Split(">")[0], parts[2].Split(">")[0]))
                .Select(parts => (parts.Item1.Split(",").Select(s => int.Parse(s.Trim())).ToArray(), parts.Item2.Split(",").Select(s => int.Parse(s.Trim())).ToArray()))
                .Select(parts => (PosX: parts.Item1[0], PosY: parts.Item1[1], VelX: parts.Item2[0], VelY: parts.Item2[1]))
                .ToImmutableArray();

            var messageState = EnumerableExtensions
                .TupleGenerate(
                    startingState,
                    0,
                    (_, __) => true,
                    (lastState, time) => (lastState.Select(last => (last.PosX + last.VelX, last.PosY + last.VelY, last.VelX, last.VelY)).ToImmutableArray(), time + 1))
                .First(state => state.Item1.Max(p => p.PosY) - state.Item1.Min(p => p.PosY) <= 10);

            var minY = messageState.Item1.Min(p => p.PosY);
            var maxY = messageState.Item1.Max(p => p.PosY);
            var minX = messageState.Item1.Min(p => p.PosX);
            var maxX = messageState.Item1.Max(p => p.PosX);

            var width = maxX - minX + 1;
            var height = maxY - minY + 1;

            var buffer = new bool[height, width];

            foreach (var tuple in messageState.Item1)
            {
                buffer[tuple.PosY - minY, tuple.PosX - minX] = true;
            }

            return "\n" + string.Join(
                "\n",
                Enumerable
                    .Range(0, height)
                    .Select(
                        y => string.Join(string.Empty,
                            Enumerable.Range(0, width)
                                .Select(x => buffer[y, x] ? "#" : "."))));
        }


        private static int Day10Part2(string input)
        {
            var startingState = input
                .SelectLines()
                .Select(s => s.Split("<"))
                .Select(parts => (parts[1].Split(">")[0], parts[2].Split(">")[0]))
                .Select(parts => (parts.Item1.Split(",").Select(s => int.Parse(s.Trim())).ToArray(), parts.Item2.Split(",").Select(s => int.Parse(s.Trim())).ToArray()))
                .Select(parts => (PosX: parts.Item1[0], PosY: parts.Item1[1], VelX: parts.Item2[0], VelY: parts.Item2[1]))
                .ToImmutableArray();

            var messageState = EnumerableExtensions
                .TupleGenerate(
                    startingState,
                    0,
                    (_, __) => true,
                    (lastState, time) => (lastState.Select(last => (last.PosX + last.VelX, last.PosY + last.VelY, last.VelX, last.VelY)).ToImmutableArray(), time + 1))
                .First(state => state.Item1.Max(p => p.PosY) - state.Item1.Min(p => p.PosY) <= 10);

            return messageState.Item2;
        }


        private static string Day11Part1(int gridSerialNumber)
        {
            var positions = Enumerable.Range(1, 300)
                .SelectMany(x => Enumerable.Range(1, 300).Select(y => (X: x, Y: y)))
                .Select(pos => (
                    X: pos.X,
                    Y: pos.Y,
                    PowerLevel: Program.Day11GetPowerLevel(pos.X, pos.Y, gridSerialNumber)
                ))
                .ToImmutableArray();

            var powerArray = new int[304, 304];

            foreach (var pos in positions)
            {
                powerArray[pos.X, pos.Y] = pos.PowerLevel;
            }

            var highest = int.MinValue;
            var highestX = 0;
            var highestY = 0;

            foreach (var pos in positions)
            {
                var x = pos.X;
                var y = pos.Y;
                var value = 0;
                for(var xOff = 0; xOff < 3; xOff++)
                for (var yOff = 0; yOff < 3; yOff++)
                {
                    value += powerArray[x + xOff, y + yOff];
                }

                if (value > highest)
                {
                    highest = value;
                    highestX = x;
                    highestY = y;
                }
            }

            return $"{highestX},{highestY}";
        }


        private static int Day11GetPowerLevel(int x, int y, int gridSerialNumber)
        {
            var rackId = x + 10;
            var intermediatePowerLevel = (rackId * y + gridSerialNumber) * rackId;

            return ((intermediatePowerLevel / 100) % 10) - 5;
        }


        private static string Day11Part2(int gridSerialNumber)
        {
            var summedAreaTable = new int[302, 302];

            foreach (var x in EnumerableExtensions.Range(300, 300, -1))
            foreach (var y in EnumerableExtensions.Range(300, 300, -1))
            {
                summedAreaTable[x, y] = Program.Day11GetPowerLevel(x, y, gridSerialNumber)
                    - summedAreaTable[x + 1, y + 1]
                    + summedAreaTable[x, y + 1]
                    + summedAreaTable[x + 1, y];
            }

            var highest = int.MinValue;
            var highestX = 0;
            var highestY = 0;
            var highestSize = 0;

            foreach (var size in Enumerable.Range(0, 300))
            foreach (var x in Enumerable.Range(1, 301 - size))
            foreach (var y in Enumerable.Range(1, 301 - size))
            {
                var value = summedAreaTable[x, y]
                    + summedAreaTable[x + size, y + size]
                    - summedAreaTable[x, y + size]
                    - summedAreaTable[x + size, y];

                if (value > highest)
                {
                    highest = value;
                    highestX = x;
                    highestY = y;
                    highestSize = size;
                }
            }

            return $"{highestX},{highestY},{highestSize}";
        }


        private static int Day12Part1(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            var initialState = Enumerable.Repeat('.', 20)
                .Concat(inputLines[0].Split(" ")[2])
                .Concat(Enumerable.Repeat('.', 40));

            var rules = inputLines
                .Skip(1)
                .Select(line => line.Split(" "))
                .Select(parts => (
                    Input: parts[0],
                    Result: parts[2][0]))
                .ToImmutableDictionary(t => t.Input, t => t.Result);

            var lastState = EnumerableExtensions
                .Generate(
                    initialState,
                    _ => true,
                    last => Enumerable.Repeat('.', 2)
                        .Concat(last
                            .Window(5)
                            .Where(arr => arr.Length == 5)
                            .Select(chars => rules.GetValueOrDefault(new string(chars.ToArray()), '.')))
                        .Concat(Enumerable.Repeat('.', 2)))
                .Skip(20)
                .First();

            return lastState
                .Select((ch, i) => ch == '#' ? i - 20 : 0)
                .Sum();
        }


        private static long Day12Part2(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            var initialState = Enumerable.Repeat('.', 20)
                .Concat(inputLines[0].Split(" ")[2])
                .Concat(Enumerable.Repeat('.', 200));

            var rules = inputLines
                .Skip(1)
                .Select(line => line.Split(" "))
                .Select(parts => (
                    Input: parts[0],
                    Result: parts[2][0]))
                .ToImmutableDictionary(t => t.Input, t => t.Result);

            return EnumerableExtensions
                .Generate(
                    initialState,
                    _ => true,
                    last => Enumerable.Repeat('.', 2)
                        .Concat(last
                            .Window(5)
                            .Where(arr => arr.Length == 5)
                            .Select(chars => rules.GetValueOrDefault(new string(chars.ToArray()), '.')))
                        .Concat(Enumerable.Repeat('.', 2)))
                .Select(state => state.Select((ch, i) => ch == '#' ? i - 20 : 0).Sum())
                .ExtrapolateFromLinearity(50000000000L);
        }


        private static string Day13Part1(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            var map = inputLines
                .Select(line => line
                    .Select(ch => ch == '>' || ch == '<' ? '-'
                        : ch == '^' || ch == 'v' ? '|'
                        : ch)
                    .ToImmutableArray())
                .ToImmutableArray();

            var carts = inputLines
                .SelectMany((line, row) => line
                    .Select((ch, col) => (
                        Row: row,
                        Col: col,
                        Direction: ch,
                        NextTurn: 'l',
                        Crashed: false
                    ))
                    .Where(c => c.Direction == '<' || c.Direction == '>' || c.Direction == '^' || c.Direction == 'v'))
                .OrderBy(c => c.Row)
                .ThenBy(c => c.Col)
                .ToImmutableArray();

            var ticks = EnumerableExtensions
                .Generate(
                    carts,
                    _ => true,
                    oldCarts =>
                    {
                        var usedSpots = oldCarts
                            .Select(c => (c.Row, c.Col))
                            .ToHashSet();
                        var crashes = new HashSet<(int Row, int Col)>();
                        return oldCarts
                            .Select(c => Program.Day13GetNextCartState(c, map, usedSpots, crashes))
                            .OrderBy(c => c.Row)
                            .ThenBy(c => c.Col)
                            .ToImmutableArray();
                    });

            var crashedCart = ticks
                .First(tick => tick.Any(c => c.Crashed))
                .First(c => c.Crashed);

            return $"{crashedCart.Col},{crashedCart.Row}";
        }


        private static (int Row, int Col, char Direction, char NextTurn, bool Crashed) Day13GetNextCartState(
            (int Row, int Col, char Direction, char NextTurn, bool Crashed) oldCart,
            ImmutableArray<ImmutableArray<char>> map,
            HashSet<(int Row, int Col)> usedSpots,
            HashSet<(int Row, int Col)> crashes)
        {
            if (crashes.Contains((oldCart.Row, oldCart.Col)))
            {
                return (
                    oldCart.Row,
                    oldCart.Col,
                    oldCart.Direction,
                    oldCart.NextTurn,
                    true);
            }
            var newRow = oldCart.Direction == '^' ? oldCart.Row - 1
                : oldCart.Direction == 'v' ? oldCart.Row + 1
                : oldCart.Row;
            var newCol = oldCart.Direction == '<' ? oldCart.Col - 1
                : oldCart.Direction == '>' ? oldCart.Col + 1
                : oldCart.Col;
            var newLocation = map[newRow][newCol];
            var newDirection = newLocation == '\\'
                ? (oldCart.Direction == '>' ? 'v'
                    : oldCart.Direction == '<' ? '^'
                    : oldCart.Direction == '^' ? '<'
                    : '>') // oldCart.Direction == 'v'
                : newLocation == '/'
                    ? (oldCart.Direction == '>' ? '^'
                    : oldCart.Direction == '<' ? 'v'
                    : oldCart.Direction == '^' ? '>'
                    : '<') // oldCart.Direction == 'v'
                : newLocation == '+'
                    ? (oldCart.Direction == 'v' && oldCart.NextTurn == 'l' ? '>'
                    : oldCart.Direction == 'v' && oldCart.NextTurn == 'r' ? '<'
                    : oldCart.Direction == 'v' && oldCart.NextTurn == 's' ? 'v'
                    : oldCart.Direction == '^' && oldCart.NextTurn == 'l' ? '<'
                    : oldCart.Direction == '^' && oldCart.NextTurn == 'r' ? '>'
                    : oldCart.Direction == '^' && oldCart.NextTurn == 's' ? '^'
                    : oldCart.Direction == '>' && oldCart.NextTurn == 'l' ? '^'
                    : oldCart.Direction == '>' && oldCart.NextTurn == 'r' ? 'v'
                    : oldCart.Direction == '>' && oldCart.NextTurn == 's' ? '>'
                    : oldCart.Direction == '<' && oldCart.NextTurn == 'l' ? 'v'
                    : oldCart.Direction == '<' && oldCart.NextTurn == 'r' ? '^'
                    : '<') // oldCart.Direction == '<' && oldCart.NextTurn == 's'
                : oldCart.Direction;
            var newNextTurn = newLocation == '+'
                ? (oldCart.NextTurn == 'l' ? 's' : oldCart.NextTurn == 's' ? 'r' : 'l')
                : oldCart.NextTurn;
            var crashed = usedSpots.Contains((newRow, newCol));
            usedSpots.Add((newRow, newCol));
            usedSpots.Remove((oldCart.Row, oldCart.Col));
            if (crashed)
            {
                crashes.Add((newRow, newCol));
            }

            return (
                newRow,
                newCol,
                newDirection,
                newNextTurn,
                crashed
            );
        }


        private static string Day13Part2(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            var map = inputLines
                .Select(line => line
                    .Select(ch => ch == '>' || ch == '<' ? '-'
                        : ch == '^' || ch == 'v' ? '|'
                        : ch)
                    .ToImmutableArray())
                .ToImmutableArray();

            var carts = inputLines
                .SelectMany((line, row) => line
                    .Select((ch, col) => (
                        Row: row,
                        Col: col,
                        Direction: ch,
                        NextTurn: 'l',
                        Crashed: false
                    ))
                    .Where(c => c.Direction == '<' || c.Direction == '>' || c.Direction == '^' || c.Direction == 'v'))
                .OrderBy(c => c.Row)
                .ThenBy(c => c.Col)
                .ToImmutableArray();

            var ticks = EnumerableExtensions
                    .Generate(
                        carts,
                        _ => true,
                        oldCarts =>
                        {
                            var usedSpots = oldCarts
                                .Select(c => (c.Row, c.Col))
                                .ToHashSet();
                            var crashes = new HashSet<(int Row, int Col)>();
                            return oldCarts
                                .Select(c => Program.Day13GetNextCartState(c, map, usedSpots, crashes))
                                .ToImmutableArray()
                                .Where(c => !c.Crashed && !crashes.Contains((c.Row, c.Col)))
                                .OrderBy(c => c.Row)
                                .ThenBy(c => c.Col)
                                .ToImmutableArray();
                        });

            var lastCart = ticks
                .First(tick => tick.Length == 1)[0];

            return $"{lastCart.Col},{lastCart.Row}";
        }


        private static string Day14Part1(string input)
        {
            var count = int.Parse(input);
            var startingList = ImmutableList<int>.Empty.Add(3).Add(7);
            var lastState = EnumerableExtensions
                .TupleGenerate(
                    startingList,
                    0,
                    1,
                    (recipes, _, __) => recipes.Count < count + 12,
                    (recipes, elf1, elf2) =>
                    {
                        var sum = recipes[elf1] + recipes[elf2];
                        var newRecipes = sum < 10
                            ? recipes.Add(sum)
                            : recipes.Add(sum / 10).Add(sum % 10);
                        return (
                            newRecipes,
                            (elf1 + newRecipes[elf1] + 1) % newRecipes.Count,
                            (elf2 + newRecipes[elf2] + 1) % newRecipes.Count);
                    })
                .Last();

            return string.Join(
                string.Empty,
                lastState
                    .Item1
                    .Skip(count)
                    .Take(10));
        }


        private static int Day14Part2(string input)
        {
            var startingList = ImmutableList<int>.Empty.Add(3).Add(7);
            var lastState = EnumerableExtensions
                .TupleGenerate(
                    startingList,
                    0,
                    1,
                    (_, __, ___) => true,
                    (recipes, elf1, elf2) =>
                    {
                        var sum = recipes[elf1] + recipes[elf2];
                        var newRecipes = sum < 10
                            ? recipes.Add(sum)
                            : recipes.Add(sum / 10).Add(sum % 10);
                        return (
                            newRecipes,
                            (elf1 + newRecipes[elf1] + 1) % newRecipes.Count,
                            (elf2 + newRecipes[elf2] + 1) % newRecipes.Count);
                    })
                .Select(t => (
                    Tail: string.Join(string.Empty, t.Item1.Skip(t.Item1.Count - 10)),
                    Skipped: t.Item1.Count - 10))
                .First(s => s.Tail.Contains(input));

            return lastState.Tail.IndexOf(input, StringComparison.Ordinal) + lastState.Skipped;
        }


        private static int Day15Part1(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            return Program.Day15SimulateBattle(inputLines).Outcome;
        }


        private static (int Outcome, int DeadElves) Day15SimulateBattle(ImmutableArray<string> inputLines, int elfPower = 3)
        {
            var map = inputLines
                .Select(line => line.ToArray())
                .ToArray();

            var units = Enumerable.Range(0, map.Length)
                .SelectMany(row => Enumerable.Range(0, map[0].Length)
                        .Select(col => (Row: row, Col: col, Item: map[row][col])))
                .Where(t => t.Item == 'E' || t.Item == 'G')
                .Select((t, index) => new Day15Unit
                {
                    Row = t.Row,
                    Col = t.Col,
                    Unit = t.Item,
                    HitPoints = 200,
                    AttackPower = t.Item == 'E' ? elfPower : 3
                })
                .ToImmutableArray();

            var fullRounds = 0;
            var stop = false;
            while (units.Where(u => u.HitPoints > 0).Select(u => u.Unit).Distinct().Count() > 1)
            {
                var unitsToProcess = units
                    .OrderBy(u => u.Row)
                    .ThenBy(u => u.Col)
                    .ToImmutableArray();

                foreach (var unit in unitsToProcess)
                {
                    if (unit.HitPoints <= 0) continue;

                    var foundNoEnemies = Program.Day15ProcessUnit(unit, map, units);

                    if (foundNoEnemies)
                    {
                        stop = true;
                        break;
                    }
                }

                if (stop)
                {
                    break;
                }

                fullRounds += 1;

//                Console.WriteLine($"After {fullRounds} Rounds:");
//                Program.Day15PrintMap(map, units);
            }

            return (
                Outcome: fullRounds * units.Where(u => u.HitPoints > 0).Sum(u => u.HitPoints),
                DeadElves: units.Count(u => u.Unit == 'E' && u.HitPoints <= 0));
        }


        // ReSharper disable once UnusedMember.Local
        private static void Day15PrintMap(char[][] map, ImmutableArray<Day15Unit> units)
        {
            Console.WriteLine(string.Join(
                "\n",
                map.Select((line, i) =>
                    string.Concat(
                        new string(line),
                        "  ",
                        string.Join(", ", units.Where(u => u.HitPoints > 0 && u.Row == i).OrderBy(u => u.Col))))));
        }


        private sealed class Day15Unit
        {

            public int Row;
            public int Col;
            public char Unit;
            public int HitPoints;
            public int AttackPower;

            public override string ToString()
            {
                return $"{this.Unit}@{this.Col},{this.Row}: {this.HitPoints}";
            }
        }


        private static bool Day15ProcessUnit(Day15Unit unit, char[][] map, ImmutableArray<Day15Unit> units)
        {
            var enemy = unit.Unit == 'E' ? 'G' : 'E';

            // find spaces adjacent to enemies
            var enemies = units
                .Where(u => u.Unit == enemy && u.HitPoints > 0)
                .ToImmutableArray();

            if (enemies.Length == 0)
            {
                return true;
            }

            var enemyAdjacentSpaces = enemies
                .SelectMany(e => new []
                {
                    (Row: e.Row + 1, Col: e.Col),
                    (Row: e.Row - 1, Col: e.Col),
                    (Row: e.Row, Col: e.Col + 1),
                    (Row: e.Row, Col: e.Col - 1)
                })
                .Where(pos => (pos.Row == unit.Row && pos.Col == unit.Col) || pos.Row >= 0
                    && pos.Row < map.Length
                    && pos.Col >= 0
                    && pos.Col < map[0].Length
                    && map[pos.Row][pos.Col] == '.')
                .ToImmutableHashSet();

            if (!enemyAdjacentSpaces.Contains((unit.Row, unit.Col)))
            {
                // find closest space, path and step
                var step = Program.Day15GetSteps(unit, map, enemyAdjacentSpaces)
                    .OrderBy(t => t.Distance)
                    .ThenBy(t => t.Row)
                    .ThenBy(t => t.Col)
                    .Take(1)
                    .Select(t => t.FirstStep)
                    .ToNullable()
                    .FirstOrDefault();

                // take one step
                if (step.HasValue)
                {
                    map[unit.Row][unit.Col] = '.';
                    map[step.Value.Row][step.Value.Col] = unit.Unit;
                    unit.Row = step.Value.Row;
                    unit.Col = step.Value.Col;
                }
            }

            // attack if you can
            var adjacentEnemyWithLowestHitPoints = new []
                {
                    (Row: unit.Row + 1, Col: unit.Col),
                    (Row: unit.Row - 1, Col: unit.Col),
                    (Row: unit.Row, Col: unit.Col + 1),
                    (Row: unit.Row, Col: unit.Col - 1)
                }
                .Where(pos => pos.Row >= 0
                    && pos.Row < map.Length
                    && pos.Col >= 0
                    && pos.Col < map[0].Length
                    && map[pos.Row][pos.Col] == enemy)
                .Select(pos => units.First(u => u.Row == pos.Row && u.Col == pos.Col && u.HitPoints > 0))
                .OrderBy(u => u.HitPoints)
                .ThenBy(u => u.Row)
                .ThenBy(u => u.Col)
                .FirstOrDefault();

            if (adjacentEnemyWithLowestHitPoints != null)
            {
                adjacentEnemyWithLowestHitPoints.HitPoints -= unit.AttackPower;
                if (adjacentEnemyWithLowestHitPoints.HitPoints <= 0)
                {
                    map[adjacentEnemyWithLowestHitPoints.Row][adjacentEnemyWithLowestHitPoints.Col] = '.';
                }
            }

            return false;
        }


        private static IEnumerable<(int Row, int Col, (int Row, int Col) FirstStep, int Distance)> Day15GetSteps(Day15Unit unit, char[][] map, ImmutableHashSet<(int Row, int Col)> enemyAdjacentSpaces)
        {
            var visited = new HashSet<(int Row, int Col)> {(unit.Row, unit.Col)};
            var queue = new Queue<(int Row, int Col, (int Row, int Col) FirstStep, int Distance)>();
            if (unit.Row > 0)
            {
                var step = (Row: unit.Row - 1, Col: unit.Col);
                if (map[step.Row][step.Col] == '.')
                {
                    queue.Enqueue((step.Row, step.Col, step, 1));
                }
            }
            if (unit.Col > 0)
            {
                var step = (Row: unit.Row, Col: unit.Col - 1);
                if (map[step.Row][step.Col] == '.')
                {
                    queue.Enqueue((step.Row, step.Col, step, 1));
                }
            }
            if (unit.Col < map[0].Length - 1)
            {
                var step = (Row: unit.Row, Col: unit.Col + 1);
                if (map[step.Row][step.Col] == '.')
                {
                    queue.Enqueue((step.Row, step.Col, step, 1));
                }
            }
            if (unit.Row < map.Length - 1)
            {
                var step = (Row: unit.Row + 1, Col: unit.Col);
                if (map[step.Row][step.Col] == '.')
                {
                    queue.Enqueue((step.Row, step.Col, step, 1));
                }
            }
            while (queue.Count > 0)
            {
                var next = queue.Dequeue();
                if (!visited.Contains((next.Row, next.Col)))
                {
                    visited.Add((next.Row, next.Col));
                    if (enemyAdjacentSpaces.Contains((next.Row, next.Col)))
                    {
                        yield return next;
                    }

                    if (next.Row > 0)
                    {
                        var step = (Row: next.Row - 1, Col: next.Col);
                        if (map[step.Row][step.Col] == '.')
                        {
                            queue.Enqueue((step.Row, step.Col, next.FirstStep, next.Distance + 1));
                        }
                    }
                    if (next.Col > 0)
                    {
                        var step = (Row: next.Row, Col: next.Col - 1);
                        if (map[step.Row][step.Col] == '.')
                        {
                            queue.Enqueue((step.Row, step.Col, next.FirstStep, next.Distance + 1));
                        }
                    }
                    if (next.Col < map[0].Length - 1)
                    {
                        var step = (Row: next.Row, Col: next.Col + 1);
                        if (map[step.Row][step.Col] == '.')
                        {
                            queue.Enqueue((step.Row, step.Col, next.FirstStep, next.Distance + 1));
                        }
                    }
                    if (next.Row < map.Length - 1)
                    {
                        var step = (Row: next.Row + 1, Col: next.Col);
                        if (map[step.Row][step.Col] == '.')
                        {
                            queue.Enqueue((step.Row, step.Col, next.FirstStep, next.Distance + 1));
                        }
                    }
                }
            }
        }


        private static int Day15Part2(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            return Enumerable
                .Range(4, 200)
                .Select(elfPower => Program.Day15SimulateBattle(inputLines, elfPower))
                .First(t => t.DeadElves == 0)
                .Outcome;
        }


        private static ImmutableArray<string> Day16PossibleInstructions = new[]
        {
            "addr",
            "addi",
            "mulr",
            "muli",
            "banr",
            "bani",
            "borr",
            "bori",
            "setr",
            "seti",
            "gtir",
            "gtri",
            "gtrr",
            "eqir",
            "eqri",
            "eqrr"
        }.ToImmutableArray();


        private static int Day16Part1(string input)
        {
            var samples = input
                .SelectLines()
                .Day16ExtractSamples();

            return samples
                .Count(sample => Program.Day16PossibleInstructions
                    .Select(instr => (
                        InstructionString: instr,
                        ActualAfter: Program.Day16ProcessOneInstruction(sample.Before, instr, sample.Instruction.A, sample.Instruction.B, sample.Instruction.C)))
                    .Count(t => sample.After.ToRegistersString().Equals(t.ActualAfter.ToRegistersString())) >= 3);
        }


        private static ImmutableArray<(ImmutableDictionary<int, int> Before, ImmutableDictionary<int, int> After, (int OpCode, int A, int B, int C) Instruction)> Day16ExtractSamples(this IEnumerable<string> inputLines)
        {
            return inputLines
                .Batch(3)
                .Where(batch => batch.Length == 3 && batch[0].StartsWith("Before"))
                .Select(batch =>
                {
                    var before = batch[0]
                        .Substring(9, 10)
                        .Split(",")
                        .Select((s, i) => (Register: i, Value: int.Parse(s.Trim())))
                        .ToImmutableDictionary(t => t.Register, t => t.Value);
                    var instruction = batch[1]
                        .Split(" ")
                        .Select(s => int.Parse(s.Trim()))
                        .ToImmutableArray();
                    var after = batch[2]
                        .Substring(9, 10)
                        .Split(",")
                        .Select((s, i) => (Register: i, Value: int.Parse(s.Trim())))
                        .ToImmutableDictionary(t => t.Register, t => t.Value);

                    return (
                        Before: before,
                        After: after,
                        Instruction: (
                            OpCode: instruction[0],
                            A: instruction[1],
                            B: instruction[2],
                            C: instruction[3]));
                })
                .ToImmutableArray();
        }


        private static ImmutableDictionary<int, int> Day16ProcessOneInstruction(
            ImmutableDictionary<int, int> registers,
            string instruction,
            int a,
            int b,
            int c)
        {
            var result = 0;
            switch (instruction)
            {
                case "addr":
                    result = registers.GetValueOrDefault(a, 0)
                        + registers.GetValueOrDefault(b, 0);
                    break;
                case "addi":
                    result = registers.GetValueOrDefault(a, 0)
                        + b;
                    break;
                case "mulr":
                    result = registers.GetValueOrDefault(a, 0)
                        * registers.GetValueOrDefault(b, 0);
                    break;
                case "muli":
                    result = registers.GetValueOrDefault(a, 0)
                        * b;
                    break;
                case "banr":
                    result = registers.GetValueOrDefault(a, 0)
                        & registers.GetValueOrDefault(b, 0);
                    break;
                case "bani":
                    result = registers.GetValueOrDefault(a, 0)
                        & b;
                    break;
                case "borr":
                    result = registers.GetValueOrDefault(a, 0)
                        | registers.GetValueOrDefault(b, 0);
                    break;
                case "bori":
                    result = registers.GetValueOrDefault(a, 0)
                        | b;
                    break;
                case "setr":
                    result = registers.GetValueOrDefault(a, 0);
                    break;
                case "seti":
                    result = a;
                    break;
                case "gtir":
                    result = a
                        > registers.GetValueOrDefault(b, 0) ? 1 : 0;
                    break;
                case "gtri":
                    result = registers.GetValueOrDefault(a, 0)
                        > b ? 1 : 0;
                    break;
                case "gtrr":
                    result = registers.GetValueOrDefault(a, 0)
                        > registers.GetValueOrDefault(b, 0) ? 1 : 0;
                    break;
                case "eqir":
                    result = a
                        == registers.GetValueOrDefault(b, 0) ? 1 : 0;
                    break;
                case "eqri":
                    result = registers.GetValueOrDefault(a, 0)
                        == b ? 1 : 0;
                    break;
                case "eqrr":
                    result = registers.GetValueOrDefault(a, 0)
                        == registers.GetValueOrDefault(b, 0) ? 1 : 0;
                    break;
                default:
                    throw new InvalidOperationException($"Instruction: {instruction}");
            }

            return registers.SetItem(c, result);
        }


        private static int Day16Part2(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            var samples = inputLines
                .Day16ExtractSamples();

            var possiblePairings = samples
                .SelectMany(sample => Program.Day16PossibleInstructions
                    .Select(instr => (
                        sample.After,
                        sample.Instruction,
                        InstructionString: instr,
                        ActualAfter: Program.Day16ProcessOneInstruction(sample.Before, instr, sample.Instruction.A, sample.Instruction.B, sample.Instruction.C))))
                .Where(t => t.After.ToRegistersString().Equals(t.ActualAfter.ToRegistersString()))
                .Select(t => (
                    t.Instruction.OpCode,
                    t.InstructionString))
                .Distinct()
                .ToImmutableArray();

            var opCodeToPossibleStrings = possiblePairings
                .GroupBy(t => t.OpCode)
                .ToImmutableDictionary(g => g.Key, g => g.Select(t => t.InstructionString).ToImmutableHashSet());

            while (opCodeToPossibleStrings.Any(p => p.Value.Count > 1))
            {
                var opCodesWithOneString = opCodeToPossibleStrings
                    .Where(p => p.Value.Count == 1)
                    .SelectMany(p => p.Value)
                    .ToImmutableArray();

                if (opCodesWithOneString.Length > 0)
                {
                    opCodeToPossibleStrings = opCodeToPossibleStrings
                        .Select(p => (
                            OpCode: p.Key,
                            Possibilities: p.Value.Count == 1
                                ? p.Value
                                : p.Value.Except(opCodesWithOneString)))
                        .ToImmutableDictionary(t => t.OpCode, t => t.Possibilities);
                }
            }

            // Console.WriteLine(string.Join("\n", opCodeToPossibleStrings.Select(p => $"{p.Key}: {string.Join(", ", p.Value)}")));

            var instructions = inputLines
                .Skip(samples.Length * 3)
                .Select(line =>
                {
                    var instruction = line
                        .Split(" ")
                        .Select(s => int.Parse(s.Trim()))
                        .ToImmutableArray();

                    return (
                        OpCode: instruction[0],
                        A: instruction[1],
                        B: instruction[2],
                        C: instruction[3]);
                })
                .ToImmutableArray();

            var finalState = instructions
                .Aggregate(ImmutableDictionary<int, int>.Empty,
                    (registers, instruction) => Program.Day16ProcessOneInstruction(registers, opCodeToPossibleStrings[instruction.OpCode].First(), instruction.A, instruction.B, instruction.C));

            return finalState.GetValueOrDefault(0, 0);
        }


        private static (int Part1, int Part2) Day17(string input)
        {
            var map = Program.Day17GetFinalMap(input);

            return (
                Part1: Program.Day17CountWater(map),
                Part2: Program.Day17CountFixedWater(map));
        }


        private static char[,] Day17GetFinalMap(string input)
        {
            var clayLocations = input
                .SelectLines()
                .SelectMany(line =>
                {
                    var parts = line.Split(", ");
                    var laterParts = parts[1].Substring(2).Split("..");
                    var first = int.Parse(parts[0].Substring(2));
                    var second = int.Parse(laterParts[0]);
                    var third = int.Parse(laterParts[1]);
                    return Enumerable.Range(second, third - second + 1)
                        .Select(
                            i => line[0] == 'x'
                                ? (
                                    X: first,
                                    Y: i
                                )
                                : (
                                    X: i,
                                    Y: first
                                ));
                })
                .ToImmutableArray();

            var maxX = clayLocations.Max(pos => pos.X) + 1;
            var minY = clayLocations.Min(pos => pos.Y);
            var maxY = clayLocations.Max(pos => pos.Y);

            var map = new char[maxX + 1, maxY + 1];

            for (var x = 0; x < map.GetLength(0); x++)
            for (var y = 0; y < map.GetLength(1); y++)
            {
                map[x, y] = '.';
            }

            foreach (var clayLocation in clayLocations)
            {
                map[clayLocation.X, clayLocation.Y] = '#';
            }

            var waterSpots = 0;
            var lastWater = -1;
            while (waterSpots != lastWater)
            {
                var visited = new HashSet<(int X, int Y)>();
                Program.Day17SpreadWaterDown(map, visited, maxX, maxY, 500, minY);

                lastWater = waterSpots;
                waterSpots = Program.Day17CountFixedWater(map);
            }

            return map;
        }


        private static int Day17CountFixedWater(char[,] map)
        {
            var sum = 0;
            for (var x = 0; x < map.GetLength(0); x++)
            for (var y = 0; y < map.GetLength(1); y++)
            {
                sum += map[x, y] == '~' ? 1 : 0;
            }

            return sum;
        }


        private static int Day17CountWater(char[,] map)
        {
            var sum = 0;
            for (var x = 0; x < map.GetLength(0); x++)
            for (var y = 0; y < map.GetLength(1); y++)
            {
                sum += map[x, y] == '~' || map[x, y] == '|' ? 1 : 0;
            }

            return sum;
        }


        // ReSharper disable once UnusedMember.Local
        private static void Day17PrintMap(char[,] map, int minX)
        {
            for (var y = 0; y < map.GetLength(1); y++)
            {
                for (var x = minX; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }


        private static void Day17SpreadWaterDown(
            char[,] map,
            HashSet<(int X, int Y)> visited,
            int maxX,
            int maxY,
            int sourceX,
            int sourceY)
        {
            if (visited.Contains((sourceX, sourceY)))
            {
                return;
            }

            var y = sourceY;
            while (y <= maxY
                && map[sourceX, y] != '#'
                && map[sourceX, y] != '~')
            {
                map[sourceX, y] = '|';
                visited.Add((sourceX, y));
                y += 1;
            }

            if (y > maxY)
            {
                return;
            }

            if (sourceX > 0 && map[sourceX, y - 1] != '#')
            {
                Program.Day17SpreadWaterAcross(map, visited, maxX, maxY, sourceX, y - 1);
            }
        }


        private static void Day17SpreadWaterAcross(
            char[,] map,
            HashSet<(int X, int Y)> visited,
            int maxX,
            int maxY,
            int sourceX,
            int sourceY)
        {
            var leftX = sourceX;
            while (map[leftX, sourceY] != '#'
                && map[leftX, sourceY] != '~'
                && (map[leftX, sourceY + 1] == '#' || map[leftX, sourceY + 1] == '~'))
            {
                map[leftX, sourceY] = '|';
                visited.Add((leftX, sourceY));
                leftX -= 1;
            }

            var rightX = sourceX;
            while (map[rightX, sourceY] != '#'
                && map[rightX, sourceY] != '~'
                && (map[rightX, sourceY + 1] == '#' || map[rightX, sourceY + 1] == '~'))
            {
                map[rightX, sourceY] = '|';
                visited.Add((rightX, sourceY));
                rightX += 1;
            }

            var leftCanFall = (map[leftX, sourceY + 1] != '#' && map[leftX, sourceY + 1] != '~');
            var rightCanFall = (map[rightX, sourceY + 1] != '#' && map[rightX, sourceY + 1] != '~');
            if (!leftCanFall && !rightCanFall)
            {
                for (var fillX = leftX + 1; fillX < rightX; fillX++)
                {
                    map[fillX, sourceY] = '~';
                }
            }
            else
            {
                if (leftCanFall)
                {
                    Program.Day17SpreadWaterDown(map, visited, maxX, maxY, sourceX: leftX, sourceY: sourceY);
                }
                if (rightCanFall)
                {
                    Program.Day17SpreadWaterDown(map, visited, maxX, maxY, sourceX: rightX, sourceY: sourceY);
                }
            }
        }


        private static int Day18Part1(string input)
        {
            var startingMap = input
                .SelectLines()
                .ToImmutableArray();

            var finalMap = EnumerableExtensions
                .Generate(
                    startingMap,
                    map => true,
                    Program.Day18GetNextMinute)
                .Skip(10)
                .First();

            return finalMap.Day18GetResourceValue();
        }


        private static ImmutableArray<string> Day18GetNextMinute(this ImmutableArray<string> oldMap)
        {
            var maxRow = oldMap.Length - 1;
            var maxCol = oldMap[0].Length - 1;

            return oldMap
                .Select((row, rowIndex) => string.Concat(row
                    .Select((ch, colIndex) =>
                    {
                        var (treeCount, lumberyardCount) = Program.Day18GetCounts(oldMap, rowIndex, colIndex, maxRow, maxCol);
                        return ch == '.'
                            ? treeCount >= 3 ? '|' : '.'
                            : ch == '|'
                                ? lumberyardCount >= 3 ? '#' : '|'
                                : treeCount > 0 && lumberyardCount > 0 ? '#' : '.';
                    })))
                .ToImmutableArray();
        }


        private static (int TreeCount, int LumeryardCount) Day18GetCounts(
            ImmutableArray<string> oldMap,
            int rowIndex,
            int colIndex,
            int maxRow,
            int maxCol)
        {
            var treeCount = 0;
            var lumberyardCount = 0;
            for (var row = Math.Max(0, rowIndex - 1); row <= Math.Min(maxRow, rowIndex + 1); row++)
            {
                for (var col = Math.Max(0, colIndex - 1); col <= Math.Min(maxCol, colIndex + 1); col++)
                {
                    if (row != rowIndex || col != colIndex)
                    {
                        if (oldMap[row][col] == '|')
                        {
                            treeCount++;
                        }
                        else if (oldMap[row][col] == '#')
                        {
                            lumberyardCount++;
                        }
                    }
                }
            }

            return (treeCount, lumberyardCount);
        }


        private static int Day18GetResourceValue(this ImmutableArray<string> map)
        {
            var totalTreeCount = map
                .SelectMany(s => s)
                .Count(ch => ch == '|');

            var totalLumberyardCount = map
                .SelectMany(s => s)
                .Count(ch => ch == '#');

            return totalTreeCount * totalLumberyardCount;
        }


        private static int Day18Part2(string input)
        {
            var startingMap = input
                .SelectLines()
                .ToImmutableArray();

            return EnumerableExtensions
                .Generate(
                    startingMap,
                    map => true,
                    Program.Day18GetNextMinute)
                .Select(Program.Day18GetResourceValue)
                .ExtrapolateFromPattern(1000000000);
        }


        private static int Day19Part1(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            var ipRegister = int.Parse(inputLines[0].Split(" ")[1]);

            var instructions = inputLines
                .Skip(1)
                .Select(line => line.Split(" "))
                .Select(parts => (
                    Instruction: parts[0],
                    A: int.Parse(parts[1]),
                    B: int.Parse(parts[2]),
                    C: int.Parse(parts[3])))
                .ToImmutableArray();

            var finalState = EnumerableExtensions
                .Generate(
                    (
                        Registers: ImmutableDictionary<int, int>.Empty,
                        InstructionPointer: 0
                    ),
                    state => state.InstructionPointer >= 0 && state.InstructionPointer < instructions.Length,
                    state => Program.Day19ProcessOneInstruction(state.Registers, state.InstructionPointer, ipRegister, instructions),
                    includeLast: true)
                .Last();

            return finalState.Registers.GetValueOrDefault(0, 0);
        }


        private static (ImmutableDictionary<int, int>, int) Day19ProcessOneInstruction(
            ImmutableDictionary<int, int> registers,
            int instructionPointer,
            int ipRegister,
            ImmutableArray<(string Instruction, int A, int B, int C)> instructions)
        {
            registers = registers.SetItem(ipRegister, instructionPointer);
            var (instruction, a, b, c) = instructions[instructionPointer];

            registers = Program.Day16ProcessOneInstruction(registers, instruction, a, b, c);

            instructionPointer = registers[ipRegister];
            instructionPointer++;

            return (registers, instructionPointer);
        }


        private static string Day19Part2(string input)
        {
            // Day 19 Part 2 requires decompiling and optimizing the assembly instructions

            return "Try running 'node day19-3.js'";
        }


        private static int Day20Part1(string input)
        {
            var inputTrimmed = input
                .Trim()
                .Substring(1);

            var openingDistances = new Stack<int>();
            var openingMaxDistances = new Stack<int>();
            var currentDistance = 0;
            var maxDistance = 0;
            var lastBlank = false;

            foreach (var ch in inputTrimmed)
            {
                switch (ch)
                {
                    case '(':
                        openingDistances.Push(currentDistance);
                        openingMaxDistances.Push(maxDistance);
                        break;
                    case '|':
                        currentDistance = openingDistances.Peek();
                        lastBlank = true;
                        break;
                    case ')':
                        openingDistances.Pop();
                        if (lastBlank)
                        {
                            maxDistance = openingMaxDistances.Pop();
                        }
                        break;
                    case '$':
                        break;
                    default:
                        currentDistance++;
                        lastBlank = false;
                        if (currentDistance > maxDistance)
                        {
                            maxDistance = currentDistance;
                        }
                        break;
                }
            }

            return maxDistance;
        }


        private static int Day20Part2(string input)
        {
            var inputTrimmed = input
                .Trim()
                .Substring(1);

            var openingDistances = new Stack<int>();
            var openingPositions = new Stack<(int X, int Y)>();
            var seenPositions = ImmutableHashSet<(int X, int Y)>.Empty;
            var currentDistance = 0;
            var position = (X: 0, Y: 0);
            var farCount = 0;

            seenPositions = seenPositions.Add(position);

            foreach (var ch in inputTrimmed)
            {
                switch (ch)
                {
                    case '(':
                        openingDistances.Push(currentDistance);
                        openingPositions.Push(position);
                        break;
                    case '|':
                        currentDistance = openingDistances.Peek();
                        position = openingPositions.Peek();
                        break;
                    case ')':
                        openingDistances.Pop();
                        openingPositions.Pop();
                        break;
                    case '$':
                        break;
                    case 'N':
                        position = (position.X, position.Y + 1);
                        goto default;
                    case 'E':
                        position = (position.X + 1, position.Y);
                        goto default;
                    case 'S':
                        position = (position.X, position.Y - 1);
                        goto default;
                    case 'W':
                        position = (position.X - 1, position.Y);
                        goto default;
                    default:
                        currentDistance++;
                        if (currentDistance >= 1000 && !seenPositions.Contains(position))
                        {
                            farCount++;
                        }

                        seenPositions = seenPositions.Add(position);
                        break;
                }
            }

            return farCount;
        }


        private static int Day21Part1(string input)
        {
            var inputLines = input
                .SelectLines()
                .ToImmutableArray();

            var ipRegister = int.Parse(inputLines[0].Split(" ")[1]);

            var instructions = inputLines
                .Skip(1)
                .Select(line => line.Split(" "))
                .Select(parts => (
                    Instruction: parts[0],
                    A: int.Parse(parts[1]),
                    B: int.Parse(parts[2]),
                    C: int.Parse(parts[3])))
                .ToImmutableArray();

            var stateAtLine28 = EnumerableExtensions
                .Generate(
                    (
                        Registers: ImmutableDictionary<int, int>.Empty,
                        InstructionPointer: 0
                    ),
                    state => state.InstructionPointer >= 0 && state.InstructionPointer < instructions.Length,
                    state => Program.Day19ProcessOneInstruction(state.Registers, state.InstructionPointer, ipRegister, instructions),
                    includeLast: true)
                .SkipWhile(state => state.InstructionPointer != 28)
                .Take(1)
                .Last();

            // At line 28, the program halts if register 0 equals register 1.
            return stateAtLine28.Registers[1];
        }


        private static string Day21Part2(string input)
        {
            // Day 21 Part 2 was solved by decompiling and optimizing the
            // assembly instructions to find the end condition.

            return "Try running 'node day21-3.js'";
        }


        private static int Day22Part1(int depth, (int X, int Y) target)
        {
            var erosionLevel = Program.Day22GetErosionLevels(depth, target);

            return Enumerable.Range(0, target.Y + 1)
                .SelectMany(y => Enumerable.Range(0, target.X + 1)
                    .Select(x => erosionLevel[y, x] % 3))
                .Sum();
        }


        private static int[,] Day22GetErosionLevels(int depth, (int X, int Y) target)
        {
            const int moduloThing = 20183;
            var erosionLevel = new int[target.Y + 1, target.X + 1];

            foreach (var y in Enumerable.Range(0, target.Y + 1))
            {
                foreach (var x in Enumerable.Range(0, target.X + 1))
                {
                    if ((y == 0 && x == 0) || (y == target.Y && x == target.X))
                    {
                        erosionLevel[y, x] = (0 + depth) % moduloThing;
                    }
                    else if (x == 0)
                    {
                        erosionLevel[y, x] = (y * 48271 + depth) % moduloThing;
                    }
                    else if (y == 0)
                    {
                        erosionLevel[y, x] = (x * 16807 + depth) % moduloThing;
                    }
                    else
                    {
                        erosionLevel[y, x] = (erosionLevel[y - 1, x] * erosionLevel[y, x - 1] + depth) % moduloThing;
                    }
                }
            }

            return erosionLevel;
        }


        private static int Day22Part2(int depth, (int X, int Y) target)
        {
            var erosionLevel = Program.Day22GetErosionLevels(depth, (target.X * 3, target.Y * 2));

            var possibilities =
                new Dictionary<((int X, int Y) Location, char Equipment), (int CostToHere, int TotalHeuristicCost, bool Processed)>
                {
                    { ((0, 0), 'T'), (0, (0, 0).Day22FindDistance(target), false) }
                };

            var ((location, equipment), costToLocation) = Program.Day22BestPossibility(target, possibilities);
            while (location != target || equipment != 'T')
            {
                var locationType = erosionLevel[location.Y, location.X] % 3;

                if (location.X > 0)
                {
                    Program.Day22AddPossibility(equipment, costToLocation, locationType, (location.X - 1, location.Y), erosionLevel, possibilities, target);
                }
                if (location.Y > 0)
                {
                    Program.Day22AddPossibility(equipment, costToLocation, locationType, (location.X, location.Y - 1), erosionLevel, possibilities, target);
                }
                if (location.X < target.X * 3) {
                    Program.Day22AddPossibility(equipment, costToLocation, locationType, (location.X + 1, location.Y), erosionLevel, possibilities, target);
                }
                if (location.Y < target.Y * 2) {
                    Program.Day22AddPossibility(equipment, costToLocation, locationType, (location.X, location.Y + 1), erosionLevel, possibilities, target);
                }

                if (location == target)
                {
                    possibilities[(location, 'T')] = (costToLocation + 7, costToLocation + 7, false);
                }

                ((location, equipment), costToLocation) = Program.Day22BestPossibility(target, possibilities);
            }

            return costToLocation;
        }


        private static (((int X, int Y) Location, char Equipment) Position, int CostToHere) Day22BestPossibility(
            (int X, int Y) target,
            Dictionary<((int X, int Y) Location, char Equipment), (int CostToHere, int TotalHeuristicCost, bool Processed)> possibilities)
        {
            var best = (Location: (X: -1, Y: -1), Equipment: '?');
            var bestCostToHere = int.MaxValue;
            var bestHeuristicCost = int.MaxValue;
            foreach (var pair in possibilities.Where(p => !p.Value.Processed))
            {
                if (pair.Value.TotalHeuristicCost < bestHeuristicCost)
                {
                    best = pair.Key;
                    bestCostToHere = pair.Value.CostToHere;
                    bestHeuristicCost = pair.Value.TotalHeuristicCost;
                }
            }

            possibilities[best] = (bestCostToHere, bestHeuristicCost, true);
            return (best, bestCostToHere);
        }


        private static int Day22FindDistance(this (int X, int Y) pos, (int X, int Y) dest)
        {
            return Math.Abs(pos.X - dest.X) + Math.Abs(pos.Y - dest.Y);
        }


        private static void Day22AddPossibility(
            char oldEquipment,
            int costToOldLocation,
            int oldLocationType,
            (int X, int Y) newLocation,
            int[,] erosionLevel,
            Dictionary<((int X, int Y) Location, char Equipment), (int CostToHere, int TotalHeuristicCost, bool Processed)> possibilities,
            (int X, int Y) target)
        {
            var newLocationType = erosionLevel[newLocation.Y, newLocation.X] % 3;

            var newEquipment = oldEquipment;
            if (newLocationType == 0)
            {
                if (oldEquipment == 'N')
                {
                    if (oldLocationType == 1)
                    {
                        newEquipment = 'C';
                    }
                    else // 2
                    {
                        newEquipment = 'T';
                    }
                }
            }
            else if (newLocationType == 1)
            {
                if (oldEquipment == 'T')
                {
                    if (oldLocationType == 0)
                    {
                        newEquipment = 'C';
                    }
                    else // 2
                    {
                        newEquipment = 'N';
                    }
                }
            }
            else if (newLocationType == 2)
            {
                if (oldEquipment == 'C')
                {
                    if (oldLocationType == 0)
                    {
                        newEquipment = 'T';
                    }
                    else // 1
                    {
                        newEquipment = 'N';
                    }
                }
            }

            var newCostToLocation = costToOldLocation + 1 + (oldEquipment == newEquipment ? 0 : 7);
            var newHeuristicCost = newCostToLocation + newLocation.Day22FindDistance(target);
            var newKey = (newLocation, newEquipment);

            if (possibilities.TryGetValue(newKey, out var oldValue))
            {
                if (newCostToLocation < oldValue.CostToHere)
                {
                    possibilities[newKey] = (newCostToLocation, newHeuristicCost, false);
                }
            }
            else
            {
                possibilities.Add(newKey, (newCostToLocation, newHeuristicCost, false));
            }
        }

    }

}
