using System;
using System.Collections.Immutable;
using System.Linq;

namespace AdventOfCode2018.CSharp
{

    public static class ImmutableDictionaryExtensions
    {

        public static ImmutableDictionary<TKey, TValue> UpdateValue<TKey, TValue>(
            this ImmutableDictionary<TKey, TValue> dictionary,
            TKey key,
            TValue defaultInitialValue,
            Func<TValue, TValue> updater)
        {
            return dictionary.SetItem(key, updater(dictionary.GetValueOrDefault(key, defaultInitialValue)));
        }


        public static string ToRegistersString<TValue>(
            this ImmutableDictionary<int, TValue> dictionary)
        {
            return string.Join(",", dictionary
                .OrderBy(p => p.Key)
                .Select(p => $"{p.Key}:{p.Value}"));
        }

    }

}
