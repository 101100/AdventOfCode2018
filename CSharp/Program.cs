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

    }

}
