﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
// ReSharper disable UnusedMember.Global

namespace AdventOfCode2018.CSharp
{

    public static class EnumerableExtensions
    {

        public static IEnumerable<(T, T)> AllPairs<T>(this IEnumerable<T> input)
        {
            var inputArray = input.ToArray();

            for (var i = 0; i < inputArray.Length; i++)
            {
                for (var j = i + 1; j < inputArray.Length; j++)
                {
                    yield return (inputArray[i], inputArray[j]);
                }
            }
        }


        public static IEnumerable<ImmutableArray<T>> Batch<T>(this IEnumerable<T> input, int batchSize)
        {
            var curr = new List<T>(batchSize);

            foreach (var item in input)
            {
                curr.Add(item);

                if (curr.Count == batchSize)
                {
                    yield return curr.ToImmutableArray();
                    curr.Clear();
                }
            }

            if (curr.Count > 0)
            {
                yield return curr.ToImmutableArray();
            }
        }


        public static IEnumerable<T> Debug<T>(this IEnumerable<T> input, string label = null, Func<T, string> printer = null)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"{label ?? "Got value"}: '{(printer == null ? item.ToString() : printer(item))}'");
                yield return item;
            }
        }


        public static IEnumerable<T> Generate<T>(T seed, Func<T, bool> predicate, Func<T, T> iterate)
        {
            var next = seed;
            while (predicate(next))
            {
                yield return next;
                next = iterate(next);
            }
        }


        public static IEnumerable<(T, T)> PairWise<T>(this IEnumerable<T> input)
        {
            var last = default(T);
            var first = true;
            foreach (var next in input)
            {
                if (!first)
                {
                    yield return (last, next);
                }
                last = next;
                first = false;
            }
        }


        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> input, int? repetitions = null)
        {
            return Enumerable
                .Range(0, repetitions ?? int.MaxValue)
                .SelectMany(_ => input);
        }


        public static IEnumerable<TScan> Scan<TInput, TScan>(
            this IEnumerable<TInput> input,
            TScan seed,
            Func<TScan, TInput, TScan> update)
        {
            var state = seed;

            foreach (var item in input)
            {
                state = update(state, item);
                yield return state;
            }
        }


        public static IEnumerable<string> SelectLines(this string input)
        {
            return input
                .Split("\n")
                .Select(r => r.Trim('\r'))
                .Where(s => s.Length > 0);
        }


        public static (TState1, TState2) TupleAggregate<TInput1, TInput2, TState1, TState2>(
            this IEnumerable<(TInput1, TInput2)> input,
            TState1 seed1,
            TState2 seed2,
            Func<TState1, TState2, TInput1, TInput2, (TState1, TState2)> update)
        {
            return input
                .Aggregate((seed1, seed2), (state, next) => update(state.Item1, state.Item2, next.Item1, next.Item2));
        }


        public static (TState1, TState2, TState3) TupleAggregate<TInput1, TInput2, TInput3, TState1, TState2, TState3>(
            this IEnumerable<(TInput1, TInput2, TInput3)> input,
            TState1 seed1,
            TState2 seed2,
            TState3 seed3,
            Func<TState1, TState2, TState3, TInput1, TInput2, TInput3, (TState1, TState2, TState3)> update)
        {
            return input
                .Aggregate((seed1, seed2, seed3), (state, next) => update(state.Item1, state.Item2, state.Item3, next.Item1, next.Item2, next.Item3));
        }


        public static IEnumerable<(T1, T2)> TupleGenerate<T1, T2>(T1 seed1, T2 seed2, Func<T1, T2, bool> predicate, Func<T1, T2, (T1, T2)> iterate)
        {
            var next = (seed1, seed2);
            while (predicate(next.Item1, next.Item2))
            {
                yield return next;
                next = iterate(next.Item1, next.Item2);
            }
        }


        public static IEnumerable<(T1, T2, T3)> TupleGenerate<T1, T2, T3>(T1 seed1, T2 seed2, T3 seed3, Func<T1, T2, T3, bool> predicate, Func<T1, T2, T3, (T1, T2, T3)> iterate)
        {
            var next = (seed1, seed2, seed3);
            while (predicate(next.Item1, next.Item2, next.Item3))
            {
                yield return next;
                next = iterate(next.Item1, next.Item2, next.Item3);
            }
        }


        public static IEnumerable<(T1, T2, T3, T4)> TupleGenerate<T1, T2, T3, T4>(T1 seed1, T2 seed2, T3 seed3, T4 seed4, Func<T1, T2, T3, T4, (T1, T2, T3, T4)> iterate)
        {
            var next = (seed1, seed2, seed3, seed4);
            while (true)
            {
                yield return next;
                next = iterate(next.Item1, next.Item2, next.Item3, next.Item4);
            }
            // ReSharper disable once IteratorNeverReturns
        }


        public static IEnumerable<(T1, T2, T3, T4, T5, T6)> TupleGenerate<T1, T2, T3, T4, T5, T6>(T1 seed1, T2 seed2, T3 seed3, T4 seed4, T5 seed5, T6 seed6, Func<T1, T2, T3, T4, T5, T6, (T1, T2, T3, T4, T5, T6)> iterate)
        {
            var next = (seed1, seed2, seed3, seed4, seed5, seed6);
            while (true)
            {
                yield return next;
                next = iterate(next.Item1, next.Item2, next.Item3, next.Item4, next.Item5, next.Item6);
            }
            // ReSharper disable once IteratorNeverReturns
        }


        public static IEnumerable<(TState1, TState2)> TupleScan<TInput1, TInput2, TState1, TState2>(
            this IEnumerable<(TInput1, TInput2)> input,
            TState1 seed1,
            TState2 seed2,
            Func<TState1, TState2, TInput1, TInput2, (TState1, TState2)> update)
        {
            return input
                .Scan((seed1, seed2), (state, next) => update(state.Item1, state.Item2, next.Item1, next.Item2));
        }


        public static IEnumerable<(T1, T2)> TupleScan<TInput, T1, T2>(
            this IEnumerable<TInput> input,
            T1 seed1,
            T2 seed2,
            Func<T1, T2, TInput, (T1, T2)> update)
        {
            var state = (seed1, seed2);

            foreach (var item in input)
            {
                state = update(state.Item1, state.Item2, item);
                yield return state;
            }
        }


        public static IEnumerable<(T1, T2, T3, T4, T5)> TupleScan<TInput, T1, T2, T3, T4, T5>(
            this IEnumerable<TInput> input,
            T1 seed1,
            T2 seed2,
            T3 seed3,
            T4 seed4,
            T5 seed5,
            Func<T1, T2, T3, T4, T5, TInput, (T1, T2, T3, T4, T5)> update)
        {
            var state = (seed1, seed2, seed3, seed4, seed5);

            foreach (var item in input)
            {
                state = update(state.Item1, state.Item2, state.Item3, state.Item4, state.Item5, item);
                yield return state;
            }
        }


        public static IEnumerable<T> StartWith<T>(this IEnumerable<T> input, T item)
        {
            return new[] {item}
                .Concat(input);
        }

    }

}
