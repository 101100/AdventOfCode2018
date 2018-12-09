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

    }

}
