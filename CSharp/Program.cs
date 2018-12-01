using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;

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
                // Console.WriteLine($"Part 2 (C#): {Program.Day1Part2(input)}");
                // Console.WriteLine($"Part 2 (F#): {Day1.part2(input)}");
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


        private static int? GetIntInput(string[] args)
        {
            return args.Length >= 2
                ? int.Parse(args[1])
                : default(int?);
        }


        private static string Day1Part1(string input)
        {
            return "output";
        }

    }

}
